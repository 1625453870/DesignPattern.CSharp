using DesignPattern.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.BLL
{
    /// <summary>
    /// 浅复制
    /// </summary>
    public class ShallowCopy : DesignPattern.Prototype.IBLL.ICloneable
    {
        public string Name { get; set; }
        public string Describe
        {
            get
            {
                return $"浅复制{new Random().Next(0, 100)}";
            }
        }
        public IList<TestModel> testModels { get; set; }

        public ShallowCopy()
        {
            this.testModels = new List<TestModel>();
        }

        public object Clone()
        {
            return new ShallowCopy
            {
                Name = this.Name,
                testModels = this.testModels
            };

        }
    }
}
