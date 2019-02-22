using DesignPattern.FactoryMethod.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.BLL
{
    public abstract class LoggerFactory
    {
        public void WriteLog() {
            var logger = this.CreateLogger();
            logger.WriteLog();
        }
        public abstract ILogger CreateLogger();
    }
}
