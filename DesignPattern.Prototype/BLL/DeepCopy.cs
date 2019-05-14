

using DesignPattern.Prototype.IBLL;
using DesignPattern.Prototype.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPattern.Prototype.BLL
{
    [Serializable]
    public class DeepCopy : DesignPattern.Prototype.IBLL.ICloneable
    {
        public string Name { get; set; }

        public string Describe
        {
            get
            {
                return $"深复制{new Random().Next(0, 100)}";
            }
        }

        public IList<TestModel> testModels { get; set; }

        public DeepCopy()
        {
            this.testModels = new List<TestModel>();
        }

        public object Clone()
        {
            var bf = new BinaryFormatter();
            var ms = new MemoryStream();
            bf.Serialize(ms, this);
            ms.Position = 0;
            return bf.Deserialize(ms) as DesignPattern.Prototype.IBLL.ICloneable;

        }
    }
}
