using System.Text.Json;
using System.Text.Json.Serialization;
using WPoker.Entity.Player;

namespace WPoker
{
    public partial class Form1 : Form
    {
        public List<HandCardInfo> handCardInfos = new List<HandCardInfo>();

        public Form1()
        {
            InitializeComponent();
            AAA();
        }

        private void AAA()
        {
            handCardInfos.Add(new HandCardInfo() {
                PokerCardA = Entity.Enum.CardSize.Ace,
                PokerCardB = Entity.Enum.CardSize.K,
                IsSuited = false,
                RaiseSize = 2.2,
                RaiseProportion = 50,
                CallProportion = 50,
                CheckProportion = 0,
                FoldProportion = 0
            });

            string jsonStr = JsonSerializer.Serialize(handCardInfos);
            return;
        }
    }
}
