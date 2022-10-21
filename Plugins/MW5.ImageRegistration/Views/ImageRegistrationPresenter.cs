﻿// -------------------------------------------------------------------------------------------
// <copyright file="ImageRegistrationPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MW5.Api.Concrete;
using MW5.Api.Interfaces;
using MW5.Plugins.ImageRegistration.Enums;
using MW5.Plugins.ImageRegistration.Services;
using MW5.Plugins.ImageRegistration.Views.Abstract;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Shared;

namespace MW5.Plugins.ImageRegistration.Views
{
    internal class ImageRegistrationPresenter :
        ComplexPresenter<IImageRegistrationView, ImageRegistrationCommand, ImageRegistrationModel>
    {
        private const string DiscardMesage =
            "当前影像的配准尚未完成。\n是否要取消并放弃控制点？";

        private readonly ILeastSquaresSolver _solver;
        private readonly IAppContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRegistrationPresenter"/> class.
        /// </summary>
        public ImageRegistrationPresenter(IImageRegistrationView view, ILeastSquaresSolver solver, IAppContext context)
            : base(view)
        {
            if (solver == null) throw new ArgumentNullException("solver");
            if (context == null) throw new ArgumentNullException("context");
            _solver = solver;
            _context = context;

            View.RecalculationNeeded += () => Calculate();

            View.AsForm.Shown += ViewShown;
            View.AsForm.FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Model.CanClose)
            {
                if (!MessageService.Current.Ask(DiscardMesage))
                {
                    e.Cancel = true;
                }
            }
        }

        private void ViewShown(object sender, EventArgs e)
        {
            RunCommand(ImageRegistrationCommand.LoadImage);
        }

        public override void RunCommand(ImageRegistrationCommand command)
        {
            switch (command)
            {
                case ImageRegistrationCommand.LoadImage:
                    LoadImage();
                    break;
                case ImageRegistrationCommand.Apply:
                    SaveTranform();
                    break;
                case ImageRegistrationCommand.Cancel:
                    if (Model.Registered && MessageService.Current.Ask("是否取消影像配准?"))
                    {
                        Model.Registered = false;
                        View.RemoveTransformedImage();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException("命令");
            }
        }

        /// <summary>
        /// A handler for the IView.OkButton.Click event. 
        /// If the method returns true, View will be closed and presenter.ReturnValue set to true.
        /// If the method return false, no actions are taken, so View.Close, presenter.ReturnValue
        /// should be called / set manually.
        /// </summary>
        public override bool ViewOkClicked()
        {
            return false;
        }

        /// <summary>
        /// Calculates the solution
        /// </summary>
        private double[] Calculate()
        {
            if (Model.ActivePoints.Count() < 3)
            {
                Model.ClearErrors();
                return null;
            }

            var target = Model.ActivePoints.Select(p => new Coordinate(p.X1, p.Y1)).OfType<ICoordinate>().ToList();
            var source = Model.ActivePoints.Select(p => new Coordinate(p.X2, p.Y2)).OfType<ICoordinate>().ToList();

            var cf = _solver.Calculate(source, target);

            CalculateErrors(cf);

            return cf;
        }

        /// <summary>
        /// Calculates deviations for each point and standard error across all points.
        /// </summary>
        /// <param name="cf">The cf.</param>
        private void CalculateErrors(double[] cf)
        {
            double sum = 0.0;
            
            foreach(var pnt in Model.Points)
            {
                if (!pnt.Active)
                {
                    pnt.Deviation = double.NaN;
                    continue;
                }

                double dx = pnt.X1 - (cf[0] + cf[1] * pnt.X2 + cf[2] * pnt.Y2);
                double dy = pnt.Y1 - (cf[3] + cf[4] * pnt.X2 + cf[5] * pnt.Y2);

                sum += Math.Pow(dx, 2.0) + Math.Pow(dy, 2.0);

                pnt.Deviation = Math.Sqrt(Math.Pow(dx, 2.0) + Math.Pow(dy, 2.0));
            }

            Model.UpdateAllPoints();

            Model.StdError = Math.Sqrt(sum / Model.ActivePoints.Count());
            View.UpdateView();
        }

        /// <summary>
        /// Lets user to select and image to register
        /// </summary>
        private void LoadImage()
        {
            if (!Model.CanClose)
            {
                if (!MessageService.Current.Ask(DiscardMesage))
                {
                    return;
                }

                Model.Points.Clear();
            }

            var img = Model.OpenRaster(View.AsForm);
            if (img != null)
            {
                View.AddSourceImage(img);
            }
        }

        private void SaveTranform()
        {
            if (string.IsNullOrWhiteSpace(Model.ImageFilename))
            {
                MessageService.Current.Info("未加载影像。");
                return;
            }

            if (Model.Points.Count < 3)
            {
                MessageService.Current.Info("没有足够的控制点。");
                return;
            }

            if (!Model.Points.Last().Complete)
            {
                MessageService.Current.Info("最后一个控制点丢失，请在转换之前输入它。");
                return;
            }

            var cf = Calculate();
            if (cf == null) return;

            if (!SaveTranformation(cf))
            {
                return;
            }

            Model.Registered = true;
            View.LoadTransformedImage();

            MessageService.Current.Info("影像转换成功。");
        }

        private bool SaveTranformation(double[] cf)
        {
            string filename = Model.ImageFilename;

            bool result;
            
            if (Model.Image.ImageFormat == Api.Enums.ImageFormat.Tiff)
            {
                result = SetGeoTranform(filename, cf);
            }
            else
            {
                result = WriteWorldFile(cf);
            }

            if (!result)
            {
                MessageService.Current.Warn("无法保存新的转换，请查看错误日志以获取详细信息。");
            }

            return result;
        }

        private bool WriteWorldFile(double[] cf)
        {
            string path = Model.ImageFilename + "w";
            try
            {
                using (var w = new StreamWriter(path))
                {
                    w.WriteLine(cf[1]);
                    w.WriteLine(cf[4]);
                    w.WriteLine(cf[2]);
                    w.WriteLine(cf[5]);
                    w.WriteLine(cf[0]);
                    w.WriteLine(cf[3]);
                }
            }
            catch (Exception ex)
            {
                Logger.Current.Warn("无法写入文件: " + path, ex);
                return false;
            }

            Model.Image.AssignProjection(_context.Map.Projection.Clone());
            return true;
        }

        private bool SetGeoTranform(string filename, double[] cf)
        {
            using (var ds = new GdalRasterDataset())
            {
                if (ds.Open(filename, false))
                {
                    if (ds.SetGeoTransform(cf[0], cf[1], cf[2], cf[3], cf[4], cf[5]) &&
                        ds.SetProjection(_context.Map.Projection.ExportToWkt()))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}