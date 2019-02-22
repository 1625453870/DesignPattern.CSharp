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
    /// Spring皮肤工厂
    /// </summary>
    public class SpringSkinFactory:ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }
        public IComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SpringTextField();
        }
    }
}
