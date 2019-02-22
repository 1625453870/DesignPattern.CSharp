using DesignPattern.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class SpringButton:IButton
    {
        public void Display() {
            Console.WriteLine("显示浅绿色按钮...");
        }
    }
}
