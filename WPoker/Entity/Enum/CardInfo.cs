using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPoker.Entity.Enum
{
    public class CardInfo
    {
        /// <summary>
        /// 花色
        /// </summary>
        public CardSuits Suits { get; set; }

        /// <summary>
        /// 大小(只能是A-K)
        /// </summary>
        public CardSize Size { get; set; }
    }
}
