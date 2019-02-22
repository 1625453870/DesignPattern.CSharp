using DesignPattern.AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    class Program
    {
        /*
         * 抽象工厂模式提供一个创建一系列相关或相互依赖对象的接口，而无须指定它们具体的类。抽象工厂模式又称为Kit模式，它是一种对象创建型模式。
         */
        static void Main(string[] args)
        {
            var skinFactory = (ISkinFactory)AppConfigHelper.GetSkinFactoryInstance();
            if (skinFactory == null)
            {
                Console.WriteLine("读取当前选中皮肤类型失败...");
            }

            var button = skinFactory.CreateButton();
            var textField = skinFactory.CreateTextField();
            var comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();
            Console.ReadKey();
        }
    }
}
