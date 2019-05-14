using DesignPattern.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.ConcreteBuilder
{
    /// <summary>
    /// 少林人物建造器 ： 具体建造者
    /// </summary>
    public class ShaoLinBuilder : IRoleBuilder
    {
        public override void BuilderName()
        {
            role.Name = "方丈";
        }

        public override void BuilderSex()
        {
            role.Sex = "男";
        }
    }
}

