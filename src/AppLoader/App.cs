using Hybh.RevitAPI.Toolkit.Attributes;
using Hybh.RevitAPI.Toolkit.Extensions;
using Hybh.RevitAPI.Toolkit.Utils;
using System;
using System.Linq;
using System.Reflection;

namespace AppLoader
{
    internal class App : ExternalApplication
    {
        /// <summary>
        /// 面板名称(自定义)
        /// </summary>
        private const string tabName = "快速开发";

        public override void OnStartup()
        {
            try
            {
                XmlDoc.Instance.UIapp = UIapp;
                var panel = ControlledApplication.CreatePanel(tabName, tabName);
                var types = XmlDoc.Instance.GetTypeByAttribute<HybhAttribute>(Location);
                if (types.Any())
                {
                    var sortTypes = types.OrderBy(o => o.GetCustomAttribute<HybhAttribute>().Name).ToArray();
                    for (int i = 0; i < sortTypes.Length; i++)
                    {
                        panel.AddItem(sortTypes.ElementAtOrDefault(i).GetPushButtonData());
                    }
                }
            }
            catch (Exception ex)
            {
                XmlDoc.Logger.Error(ex.Message, ex);
            }
        }
    }
}
