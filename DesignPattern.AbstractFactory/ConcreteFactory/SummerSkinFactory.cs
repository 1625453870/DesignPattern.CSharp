using DesignPattern.AbstractFactory.AbstractFactory;
using DesignPattern.AbstractFactory.AbstractProduct;
using DesignPattern.AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.ConcreteFactory
{
    /// <summary>
    /// Summer皮肤工厂
    /// </summary>
    public class SummerSkinFactory:ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SummerButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SummerComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SummerTextField();
        }
    }
}
