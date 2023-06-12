using Hybh.RevitAPI.Toolkit.Attributes;
using Hybh.RevitAPI.Toolkit.Extensions;
using Hybh.RevitAPI.Toolkit.Utils;
using System.Linq;
using System.Reflection;

namespace AppLoader
{
    internal class App : ExternalApplication
    {
        private const string tabName = "快速开发";

        public override void OnStartup()
        {
            XmlDoc.Instance.UIapp = UIapp;
            var panel = ControlledApplication.CreatePanel(tabName, tabName);
            var types = XmlDoc.Instance.GetTypeByAttribute<HybhAttribute>(Location);
            if (types.Any())
            {
                var pushButtonDatas = types.OrderBy(o => o.GetCustomAttribute<HybhAttribute>().Name)
                    .Select(o => o.GetPushButtonData());

                //// 添加功能
                foreach (var item in pushButtonDatas)
                {
                    panel.AddPushButton(item);
                }

                //// 添加下拉分割功能组
                //panel.AddSplitButton(pushButtonDatas);

                //// 添加下拉功能按钮
                //panel.AddPulldownButton("测试功能", pushButtonDatas);

            }
        }
    }
}
