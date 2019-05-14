using DesignPattern.Builder.IBuilder;
using DesignPattern.Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.ActorController
{
    /// <summary>
    /// 人物创建控制器（指挥者(Director)）
    /// </summary>
    public class RoleController
    {
        public RoleModel Construct(IRoleBuilder roleBuilder)
        {
            roleBuilder.BuilderName();
            roleBuilder.BuilderSex();
            return roleBuilder.CreateRole();
        }
    }
}
