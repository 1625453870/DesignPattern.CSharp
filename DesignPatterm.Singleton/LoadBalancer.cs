using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterm.Singleton
{
    /*
     * 饿汉式单例　
     * C#的语法中有一个函数能够确保只调用一次，那就是静态构造函数。
     * 由于C#是在调用静态构造函数时初始化静态变量，.NET运行时（CLR）能够确保只调用一次静态构造函数，这样我们就能够保证只初始化一次instance。
     * 过早地创建实例，从而降低内存的使用效率
     */
    public class LoadBalancer
    {
        // 私有静态变量，存储唯一实例
        private static readonly LoadBalancer insrance =null;
        // 服务器集合
        private List<CustomServer> serverList = null;

        public LoadBalancer() {

        }


        public static LoadBalancer GetLoadBalancer() {
            return insrance;
        }

        #region 无关代码测试操作

        // 添加一台Server
        public void AddServer(CustomServer server)
        {
            serverList.Add(server);
        }

        // 移除一台Server
        public void RemoveServer(string serverName)
        {
            foreach (var server in serverList)
            {
                if (server.Name.Equals(serverName))
                {
                    serverList.Remove(server);
                    break;
                }
            }
        }

        // 获得一台Server - 使用随机数获取
        private Random rand = new Random();
        public CustomServer GetServer()
        {
            int index = rand.Next(serverList.Count);

            return serverList[index];
        } 
        #endregion
    }
}
