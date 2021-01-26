using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleRoom
{
    public class Game : GameSale
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

    }
}
