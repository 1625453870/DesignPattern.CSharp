using DesignPattern.Prototype.BLL;
using DesignPattern.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class PrototypeManager
    {
        private Dictionary<PrototypeEnum, CopyDocument> dict = new Dictionary<PrototypeEnum, CopyDocument>();

        public static PrototypeManager GetInstance
        {
            get
            {
                return Nested.prototypeManager;
            }
        }

        class Nested
        {
            internal static readonly PrototypeManager prototypeManager = new PrototypeManager();
        }

        private PrototypeManager()
        {
            dict.Add(PrototypeEnum.SCopy, new SCopy());
            dict.Add(PrototypeEnum.DCopy, new DCopy());
        }

        /// <summary>
        /// 获取值
        /// </summary>
        /// <param name="prototypeEnum"></param>
        /// <returns></returns>
        public CopyDocument GetCopyDocumentByKey(PrototypeEnum prototypeEnum)
        {
            if (dict.ContainsKey(prototypeEnum))
            {
                return dict[prototypeEnum].Clone();
            }
            return null;
        }

        /// <summary>
        /// 新增值
        /// </summary>
        /// <param name="prototypeEnum"></param>
        /// <param name="copyDocument"></param>
        public void AddCopyDocument(PrototypeEnum prototypeEnum, CopyDocument copyDocument)
        {
            if (!dict.ContainsKey(prototypeEnum))
            {
                dict.Add(prototypeEnum, copyDocument);
            }
        }
    }
}
