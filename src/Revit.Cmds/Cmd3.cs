using Autodesk.Revit.DB;
using Hybh.RevitAPI.Toolkit.Utils;

namespace Revit.Cmds
{
    [Hybh.RevitAPI.Toolkit.Attributes.Hybh("测试3", "功能提示信息", "鼠标悬停详细提示")]
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Cmd3 : RevitCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
            XmlDoc.Print("测试功能3");
        }
    }
}
