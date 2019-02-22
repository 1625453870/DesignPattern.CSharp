using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterm.SimpleFactory
{
    public class AppConfigHelper
    {
        /// <summary>
        /// 从webconfig配置中读取类型
        /// </summary>
        /// <returns></returns>
        public static string GetChartType()
        {
            return ConfigurationManager.AppSettings["charttype"];
        }
    }
}
