using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPoker.Entity.Enum;
using WPoker.Entity.Player;

namespace WPoker.Entity
{
    public class PokerRangeTableForSixInfo
    {
        public TableForSixLocation Location { get; set; }

        public List<HandCardInfo> HandCardCompose { get; set; }
    }
}
