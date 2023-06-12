using Autodesk.Revit.DB;
using Hybh.RevitAPI.Toolkit.Utils;

namespace Revit.Cmds
{
    [Hybh.RevitAPI.Toolkit.Attributes.Hybh("测试2", "功能提示信息")]
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Cmd2 : RevitCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
            XmlDoc.Print("测试功能2");
        }
    }
}
