using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPoker.Entity.Enum;

namespace WPoker.Entity.Player
{
    public class HandCardInfo
    {
        public CardSize PokerCardA {  get; set; }

        public CardSize PokerCardB { get; set; }

        public bool IsSuited { get; set; }

        public double CallProportion { get; set; }

        public double RaiseProportion { get; set; }

        public double RaiseSize { get; set; }

        public double CheckProportion { get; set; }

        public double FoldProportion { get; set; }
    }
}
