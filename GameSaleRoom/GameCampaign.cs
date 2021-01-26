using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleRoom
{
    public class GameCampaign : ICampaign
    {
        public void Add(Game game)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Game game)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Game game)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Kampanya Güncenllendi");
        }
    }
}
