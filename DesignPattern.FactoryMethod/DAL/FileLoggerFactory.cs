using DesignPattern.FactoryMethod.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.DAL
{
    /// <summary>
    /// 创建文件日志记录器
    /// </summary>
   public  class FileLoggerFactory: ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            var logger = new FileLogger();
            return logger;
        }
    }
}
