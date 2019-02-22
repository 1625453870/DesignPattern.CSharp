using DesignPattern.FactoryMethod.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.DAL
{
    /// <summary>
    /// 文件日志
    /// </summary>
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志记录...");
        }
    }
}
