using Autodesk.Revit.DB;
using Hybh.RevitAPI.Toolkit.Utils;

namespace Revit.Cmds
{
    [Hybh.RevitAPI.Toolkit.Attributes.Hybh("测试功能1")]
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Cmd1 : RevitCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
            XmlDoc.Print(uidoc.Document.Title);
        }
    }
}
