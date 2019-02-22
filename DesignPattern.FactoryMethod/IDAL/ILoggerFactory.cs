using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.IDAL
{
    /// <summary>
    ///  创建文件日志记录器
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
