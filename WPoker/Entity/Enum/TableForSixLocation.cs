using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPoker.Entity.Enum
{
    /// <summary>
    /// 六人桌位置
    /// </summary>
    public enum TableForSixLocation
    {
        /// <summary>
        /// 莊位
        /// </summary>
        BTN,

        /// <summary>
        /// 小盲位
        /// </summary>
        SB,

        /// <summary>
        /// 大盲位
        /// </summary>
        BB,

        /// <summary>
        /// 槍口位
        /// </summary>
        UTG,

        /// <summary>
        /// Hijack
        /// </summary>
        HJ,

        /// <summary>
        /// Cutoff
        /// </summary>
        CO,
    }
}
