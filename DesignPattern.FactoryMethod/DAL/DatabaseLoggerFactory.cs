using DesignPattern.FactoryMethod.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.DAL
{
    /// <summary>
    /// 创建数据库日志记录器对象
    /// </summary>
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            // 连接数据库，代码省略
            // 创建数据库日志记录器对象
            ILogger logger = new DatabaseLogger();
            // 初始化数据库日志记录器，代码省略
            return logger;
        }
    }
}
