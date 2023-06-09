using Autodesk.Revit.DB;
using Hybh.RevitAPI.Toolkit.Utils;

namespace Revit.Cmds
{
<<<<<<< HEAD
    [Hybh.RevitAPI.Toolkit.Attributes.Hybh("测试功能1")]
=======
    [Hybh.RevitAPI.Toolkit.Attributes.Hybh("功能名称1")]
>>>>>>> 2880d01 (初始化项目)
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Cmd1 : RevitCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
            XmlDoc.Print(uidoc.Document.Title);
        }
    }
}
