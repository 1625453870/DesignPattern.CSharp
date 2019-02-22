using DesignPattern.FactoryMethod.BLL;
using DesignPattern.FactoryMethod.DAL;
using DesignPattern.FactoryMethod.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class Program
    {
        /*
         * 工厂方法（Factory Method）模式：定义一个用于创建对象的接口，让子类决定将哪一个类实例化。工厂方法模式让一个类的实例化延迟到其子类。工厂方法模式又简称为工厂模式，也可称为多态工厂模式，它是一种创建型模式。　　
         */
        static void Main(string[] args)
        {
            #region 不隐藏工厂方法
            var factory = new DAL.FileLoggerFactory(); // 可通过引入配置文件实现
            if (factory == null)
            {
                return;
            }

            var logger = factory.CreateLogger();
            logger.WriteLog();
            #endregion

            #region 隐藏工厂方法
            var factory1 = (LoggerFactory)AppConfigHelper.GetLoggerFactoryInstance();
            if (factory1 == null)
            {
                return;
            }

            factory1.WriteLog();
            #endregion
            Console.ReadKey();
        }
    }
}
