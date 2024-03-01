using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPoker.Entity.Enum
{
    public enum CardAction
    {
        /// <summary>
        /// 跟注
        /// </summary>
        Call,

        /// <summary>
        /// 過牌
        /// </summary>
        Check,

        /// <summary>
        /// 加注
        /// </summary>
        Raise,

        /// <summary>
        /// 棄牌
        /// </summary>
        Fold,
    }
}
