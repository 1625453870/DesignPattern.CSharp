using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterm.Singleton
{
    public class LoadBalancer
    {
        // 私有静态变量，存储唯一实例
        private static LoadBalancer instance = null;

        //最低级的单例实现，一开始就生成
        //private static readonly LoadBalancer instance = new LoadBalancer();

        //lock锁
        private static readonly object syncLocker = new object();

        // 服务器集合
        private List<CustomServer> serverList = null;

        public LoadBalancer() {
            serverList = new List<CustomServer>();
        }

        // 公共静态成员方法，返回唯一实例
        public static LoadBalancer GetLoadBalancer() {
            //#region 双重检查锁定
            ////第一重检查
            //if (instance == null)
            //{
            //    //锁定
            //    lock (syncLocker)
            //    {
            //        //第二重检查
            //        if (instance == null)
            //        {
            //            instance = new LoadBalancer();
            //        }
            //    }
            //}
            //return instance; 
            //#endregion
            return Nested.insrance;
        }

        class Nested {
            internal static readonly LoadBalancer insrance = new LoadBalancer();
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
