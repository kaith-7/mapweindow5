using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Helpers;
using MW5.Plugins.ImageRegistration.Views;
using MW5.Shared;
using MW5.Tools.Model;

namespace MW5.Plugins.ImageRegistration.Tools
{
    [CustomLayout]
    [GisTool(GroupKeys.Raster)]
    public class ImageRegistrationTool : ToolBase
    {
        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name => "影像配准";

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description =>
            "可交互式地匹配图像和地图上的已知位置，并计算仿射变换系数以重置图像的位置。";

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity => PluginIdentityHelper.GetIdentity(typeof(ImageRegistrationPlugin));

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run()
        {
            var model = new ImageRegistrationModel();
            return _context.Container.Run<ImageRegistrationPresenter, ImageRegistrationModel>(model);
        }
    }
}
