using DesignPattern.Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.IBuilder
{
    /// <summary>
    /// 人物建造器 ： 抽象建造者
    /// </summary>
    public abstract class IRoleBuilder
    {
        protected RoleModel role = new RoleModel();

       public abstract void BuilderName();
        public abstract void BuilderSex();

        public RoleModel CreateRole()
        {
            return this.role;
        }

    }
}
