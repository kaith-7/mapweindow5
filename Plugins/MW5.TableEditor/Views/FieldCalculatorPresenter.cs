﻿// -------------------------------------------------------------------------------------------
// <copyright file="FieldCalculatorPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using MW5.Api.Concrete;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.TableEditor.Views.Abstract;
using MW5.Shared;

namespace MW5.Plugins.TableEditor.Views
{
    /// <summary>
    /// Validates and calculates expression for a given field.
    /// </summary>
    public class FieldCalculatorPresenter : BasePresenter<IFieldCalculatorView, FieldCalculatorModel>
    {
        public FieldCalculatorPresenter(IFieldCalculatorView view)
            : base(view)
        {
            view.TestClicked += OnTestClicked;
        }

        public override bool ViewOkClicked()
        {
            return Validate() && CalculateField();
        }

        /// <summary>
        /// Calculates expression and saves results in to the table.
        /// </summary>
        private bool CalculateField()
        {
            var eval = ParseExpression();

            var count = 0;
            var rowCount = Model.Table.NumRows;
            bool errorReported = false;

            for (var i = 0; i < rowCount; i++)
            {
                if (!eval.CalculateForTableRow(i, Model.Field.Index))
                {
                    if (!errorReported)
                    {
                        // report only the very first error
                        string s = "表达式计算失败行: " + i + ". " + eval.LastErrorMessage;
                        Logger.Current.Info(s);
                        errorReported = true;
                    }
                    continue;
                }
                
                count++;
            }

            Model.Field.Expression = View.Expression;   

            if (count != rowCount)
            {
                MessageService.Current.Info(string.Format("Rows calculated: {0} from {1}", count, rowCount));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Parses expression and calculates if for the first row.
        /// </summary>
        private bool Validate()
        {
            var eval = ParseExpression();
            if (eval == null)
            {
                return false;
            }

            object result;
            if (!eval.CalculateForTableRow2(0, out result))
            {
                return MessageService.Current.Ask(
                        "第一行表达式计算失败: " + eval.LastErrorMessage
                        + "尝试对其他行执行相同计算?");
            }

            return true;
        }

        /// <summary>
        /// Calculates expression for first 5 rows of the table and displays results in message box.
        /// </summary>
        private void OnTestClicked()
        {
            var eval = ParseExpression();
            if (eval == null)
            {
                return;
            }

            var results = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                object result;
                if (!eval.CalculateForTableRow2(i, out result))
                {
                    results.Add("<计算失败>");
                }
                else
                {
                    string s= string.Format("记录 {0}: ", i) + result;
                    results.Add( s);
                }
            }

            string msg = "计算结果: " + Environment.NewLine + Environment.NewLine;
            msg += StringHelper.Join(results, Environment.NewLine + Environment.NewLine);

            MessageService.Current.Info(msg);
        }

        /// <summary>
        /// Parses the expression and returns evaluator instances if it succeeds.
        /// </summary>
        private MW5.Api.Concrete.ExpressionEvaluator ParseExpression()
        {
            var expr = View.Expression;
            if (string.IsNullOrWhiteSpace(expr))
            {
                MessageService.Current.Info("表达式无效。");
                return null;
            }

            var eval = new MW5.Api.Concrete.ExpressionEvaluator();

            if (!eval.ParseForTable(expr, Model.Table))
            {
                MessageService.Current.Info("解析表达式失败: " + eval.LastErrorMessage);
                return null;
            }

            return eval;
        }
    }
}