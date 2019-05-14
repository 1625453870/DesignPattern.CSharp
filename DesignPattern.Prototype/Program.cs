using DesignPattern.Prototype.BLL;
using DesignPattern.Prototype.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    class Program
    {
        /*
    浅复制：复制一个对象的时候，仅仅复制原始对象中所有的非静态类型成员和所有的引用类型成员的引用。
    （新对象和原对象将共享所有引用类型成员的实际对象）

　　深复制：复制一个对象的时候，不仅复制所有非静态类型成员，还要复制所有引用类型成员的实际对象。
             */
        static void Main(string[] args)
        {


            Console.WriteLine("---------浅复制--------");
            var model = new ShallowCopy();
            model.testModels.Add(new TestModel { Id = 1, Name = "zx1" });

            //浅复制
            var model1 = model.Clone() as ShallowCopy;


            Console.WriteLine($"model和model1是否相同:{object.ReferenceEquals(model, model1)}");
            Console.WriteLine($"model和model1的testModels是否相同:{object.ReferenceEquals(model.testModels, model1.testModels)}");

            Console.WriteLine("---------深复制--------");

            var model2 = new DeepCopy();
            model2.testModels.Add(new TestModel { Id = 1, Name = "zx1" });

            //浅复制
            var model3 = model2.Clone() as DeepCopy;


            Console.WriteLine($"model2和model3是否相同:{object.ReferenceEquals(model2, model3)}");
            Console.WriteLine($"model2和model3的testModels是否相同:{object.ReferenceEquals(model2.testModels, model3.testModels)}");


            Console.WriteLine("---------原型管理器--------");
            var prototypeManager = PrototypeManager.GetInstance;
            var doc1 = prototypeManager.GetCopyDocumentByKey(PrototypeEnum.DCopy) as DCopy;
            var doc2 = prototypeManager.GetCopyDocumentByKey(PrototypeEnum.DCopy) as DCopy;
            var doc3 = prototypeManager.GetCopyDocumentByKey(PrototypeEnum.SCopy) as SCopy;
            var doc4 = prototypeManager.GetCopyDocumentByKey(PrototypeEnum.SCopy) as SCopy;

            Console.WriteLine($"doc1深复制--名称:{doc1.Name}  描述:{doc1.Describe}");
            Console.WriteLine($"doc2深复制--名称:{doc2.Name}  描述:{doc2.Describe}");
            Console.WriteLine("是否是同一个深复制：{0}", object.ReferenceEquals(doc1, doc2));
            Console.WriteLine("是否是同一个testModels集合：{0}", object.ReferenceEquals(doc1.testModels, doc2.testModels));

            Console.WriteLine($"doc1浅复制--名称:{doc3.Name}  描述:{doc3.Describe}");
            Console.WriteLine($"doc2浅复制--名称:{doc4.Name}  描述:{doc4.Describe}");
            Console.WriteLine("是否是同一个浅复制：{0}", object.ReferenceEquals(doc3, doc4));
            Console.WriteLine("是否是同一个testModels集合：{0}", object.ReferenceEquals(doc3.testModels, doc4.testModels));
            Console.ReadKey();
        }
    }
}
