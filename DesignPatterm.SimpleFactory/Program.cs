using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterm.SimpleFactory
{
    class Program
    {
        /*
         * 简单工厂（Simple Factory）模式：定义一个工厂类，它可以根据参数的不同返回不同类的实例，被创建的实例通常都具有共同的父类。因为在简单工厂模式中用于创建实例的方法是静态（static）方法，因此简单工厂模式又被称为静态工厂方法模式，它属于创建型模式。
         */
        static void Main(string[] args)
        {
            var chart = ChartFactory.GetChart("histogram");
            if (chart != null)
                chart.Display();
            chart = ChartFactory.GetChart("pie");
            if (chart != null)
                chart.Display();

           
            chart = ChartFactory.GetChart(AppConfigHelper.GetChartType());
            if (chart != null)
            {
                chart.Display();
            }
            Console.ReadKey();
                    
        }
    }
}
