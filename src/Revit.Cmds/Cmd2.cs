using Autodesk.Revit.DB;
using Hybh.RevitAPI.Toolkit.Utils;

namespace Revit.Cmds
{
<<<<<<< HEAD
    [Hybh.RevitAPI.Toolkit.Attributes.Hybh("测试功能2", "功能提示信息")]
=======
    [Hybh.RevitAPI.Toolkit.Attributes.Hybh("功能名称2", "功能提示信息")]
>>>>>>> 2880d01 (初始化项目)
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Cmd2 : RevitCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
<<<<<<< HEAD
            XmlDoc.Print("测试功能2");
=======
            XmlDoc.Print(uidoc.Document.PathName);
>>>>>>> 2880d01 (初始化项目)
        }
    }
}
