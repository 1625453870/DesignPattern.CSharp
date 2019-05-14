using DesignPattern.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.ConcreteBuilder
{
    /// <summary>
    /// 华山人物建造器 ： 具体建造者
    /// </summary>
    public class HuaShanBuilder : IRoleBuilder
    {
        public override void BuilderName()
        {
            role.Name = "岳灵珊";
        }

        public override void BuilderSex()
        {
            role.Sex = "女";
        }
    }
}
