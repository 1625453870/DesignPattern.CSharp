using DesignPattern.Prototype.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype.BLL
{
    public interface CopyDocument : ICloneable
    {
        new CopyDocument Clone();//隐藏ICloneable的Clone接口方法定义
    }

    public class SCopy : CopyDocument
    {
        public string Name { get { return "浅复制"; } }
        public IList<TestModel> testModels { get; set; }
        public string Describe
        {
            get
            {
                var r = new Random();
                var n = r.Next(0, 100);
                return $"浅复制{n}";
            }
        }
        public SCopy()
        {
            this.testModels = new List<TestModel>();
        }
        public CopyDocument Clone()
        {
            return new SCopy {
                testModels=this.testModels
            };
        }
        
        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }

    [Serializable]
    public class DCopy : CopyDocument
    {
        public string Name { get { return "深复制"; } }
        public IList<TestModel> testModels { get; set; }
        public string Describe
        {
            get
            {
                var r = new Random();
                var n = r.Next(0, 100);
                return $"深复制{n}";
            }
        }
        public DCopy()
        {
            this.testModels = new List<TestModel>();
        }
        public CopyDocument Clone()
        {
            var bf = new BinaryFormatter();
            var ms = new MemoryStream();
            bf.Serialize(ms, this);
            ms.Position = 0;
            return bf.Deserialize(ms) as CopyDocument;
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
