using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterm.Singleton
{
    class Program
    {
        /*
        单例（Singleton）模式：确保某一个类只有一个实例，而且自行实例化并向整个系统提供这个实例，这个类称为单例类，它提供全局访问的方法。单例模式是一种对象创建模式。
        */
        static void Main(string[] args)
        {
            var aa = LoadBalancer.GetLoadBalancer();
            Console.ReadKey();
        }
    }
}
