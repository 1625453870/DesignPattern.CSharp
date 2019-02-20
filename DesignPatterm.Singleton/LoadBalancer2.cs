using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterm.Singleton
{
    public class LoadBalancer2
    {

        /*
         * 懒汉式单例
         
             */
        // 私有静态变量，存储唯一实例
        private static LoadBalancer2 instace = null;
        private static readonly object sysncLocker = new object();

        public static LoadBalancer2 GetLoadBalancer() {
            #region 单检查锁定
            /*
             * 问题貌似得以解决，但事实并非如此。如果使用以上代码来创建单例对象，还是会存在单例对象不一致。
             * 假设线程A先进入lock代码块内，执行实例化代码。此时线程B排队吃瓜等待，必须等待线程A执行完毕后才能进入lock代码块。
             * 但当A执行完毕时，线程B并不知道实例已经被创建，将继续创建新的实例，从而导致多个单例对象。
             */
            if (instace == null)
            {
                lock (sysncLocker)
                {
                    instace = new LoadBalancer2();
                }
            }
           
            #endregion

            if (instace == null)
            {
                lock (sysncLocker)
                {
                    if (instace == null)
                    {
                        instace = new LoadBalancer2();
                    }
                }
            }
            return instace;
        }
    }
}
