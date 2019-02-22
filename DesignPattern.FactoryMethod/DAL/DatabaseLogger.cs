using DesignPattern.FactoryMethod.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.DAL
{
    /// <summary>
    /// 数据库日志
    /// </summary>
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("数据库日志记录...");
        }
    }
}
