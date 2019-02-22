using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
   public class AppConfigHelper
    {
        public static string GetLoggerFactoryName()
        {
           return ConfigurationManager.AppSettings["LoggerFactory"];
        }

        public static object GetLoggerFactoryInstance()
        {
            string assemblyName = AppConfigHelper.GetLoggerFactoryName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
