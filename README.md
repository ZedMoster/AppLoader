# Revit 快速开发

## 安装

可以使用 [nuget package](https://www.nuget.org/packages/Hybh.RevitAPI.Toolkit) 安装.

```text
<PackageReference Include="Hybh.RevitAPI.Toolkit" Version="*" />
```

## 简介

### 目录

* [External command](#external-command)
* [External application](#external-application)
* [Transaction](#transaction)
* [Extensions](#extensions)
* [XmlDoc](#xmldoc)

### **External command**

 **RevitCommand** 类实现了 **IExternalCommand** 接口.

可以自动监控 *Autodesk.Revit.Exceptions.OperationCanceledException* 操作.

```c#
    [Hybh("测试")]
    [Transaction(TransactionMode.Manual)]
    public class CmdTest : RevitCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
            // 弹窗打印当前项目名称
            XmlDoc.Print(uidoc.Document.Title);
        }
    }
```

### **External Application**


获取程序集目录下类库中包含全部的 **HybhAttribute** 特性的功能,添加功能区面板 

```c#
    public class App : ExternalApplication
    {
        private const string tabName = "快速开发";

        public override void OnStartup()
        {
            try
            {
                XmlDoc.Instance.UIapp = UIapp;
                var panel = ControlledApplication.CreatePanel(tabName, tabName);
                var types = XmlDoc.Instance.GetTypeByAttribute<HybhAttribute>(Location);
                XmlDoc.Logger.Debug("types Count:" + types.Count());
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
                XmlDoc.Print(ex.Message);
            }
        }
    }
```

### **Transaction**

实现事务及事务组拓展方法

#### 事务

```C#
    doc.Transaction(t =>
    { 
        // doc.Delete(wall.Id);

    }, "事务名称");
```

#### 事务组

```C#
    doc.TransactionGroup(tg => {
        doc.Transaction(t =>
        { 
            // doc.Delete(wall.Id);

        });
        doc.Transaction(t =>
        { 
            // doc.Delete(window.Id);

        });
    }, "事务组名称");
```

### **Extensions**

自定义拓展方法实现快速开发

添加命令空间引用

*using Hybh.RevitAPI.Toolkit.Extensions*

可使用下方拓展方法

- ConvertExtensions
- CurveExtensions
- DocumentExtensions
- ElementExtensions
- ElementIdExtensions
- ImageExtensions
- MEPCurveExtensions
- ReferenceExtensions
- RoomExtensions
- StringExtensions
- TransactionExtensions
- TypeExtensions
- UIControlledApplicationExtensions
- XYZExtensions

### **XmlDoc**

XmlDoc包含 

- *UIapp*, *UIdoc* 常用属性
- *Task* 为外部事件封装方法
- *Print* 可快速弹窗提示
- *Logger* 包含 *Debug*,*Error*,*Infor* 日志信息
