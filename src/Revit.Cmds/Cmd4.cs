﻿using Autodesk.Revit.DB;
using Hybh.RevitAPI.Toolkit.Utils;

namespace Revit.Cmds
{
    [Hybh.RevitAPI.Toolkit.Attributes.Hybh("测试功能")]
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Cmd4 : RevitCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
            XmlDoc.Print("测试功能");
        }
    }
}
