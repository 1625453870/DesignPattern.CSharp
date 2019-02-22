using DesignPattern.FactoryMethod.DAL;
using DesignPattern.FactoryMethod.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.BLL
{
    public class FileLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            // 创建文件日志记录器对象
            var logger = new FileLogger();
            return logger;
        }
    }
}
