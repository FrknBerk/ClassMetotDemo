using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleRoom
{
    public abstract class GameSale : ISalesManager
    {
        public virtual void GameList(Game[] games)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (Game game in games)
            {
                Console.WriteLine("Oyun Id: " + game.GameId + " Oyun Adı: " + game.GameName
                    + " Oyun Türü: " + game.Type + " Fiyatı: " + game.Price + "$\n");
            }
        }

        public virtual void WeekendCampaign(Game game)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oyun Id: " + game.GameId + " Oyun Adı: " + game.GameName +
                " Oyun Türü: " + game.Type + " Kampanyalı Fiyat : " + ((game.Price) - (game.Price) * 20 / 100) + "$\n");
        }

        public virtual void BlackFridayCampaign(Game game)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oyun Id: " + game.GameId + " Oyun Adı: " + game.GameName +
                " Oyun Türü: " + game.Type + " Kampanyalı Fiyat : " + ((game.Price) - (game.Price) * 50 / 100) + "$\n");
        }

        public virtual void NewYearCampaign(Game game)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oyun Id: " + game.GameId + " Oyun Adı: " + game.GameName +
                " Oyun Türü: " + game.Type + " Kampanyalı Fiyat : " + ((game.Price) - (game.Price) * 75 / 100) + "$\n");
        }

        public virtual void WeekendCampaignSale(Game game, Gamer gamer)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Oyun Id: " + game.GameId + " Oyun Adı: " + game.GameName +
                " Oyun Türü: " + game.Type + " Oyun Fiyatı: " + ((game.Price)- (game.Price)*20/100) + "$ "+
                gamer.GamerFirstName+ " " +gamer.GamerLastName+" oyuncuya satıldı."+"\n");
        }

        public virtual void BlackFridayCampaignSale(Game game, Gamer gamer)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Oyun Id: " + game.GameId + " Oyun Adı: " + game.GameName +
                " Oyun Türü: " + game.Type + " Oyun Fiyatı: " + ((game.Price) - (game.Price) * 50 / 100) + "$ " +
                gamer.GamerFirstName + " " + gamer.GamerLastName + " oyuncuya satıldı." + "\n");
        }

        public virtual void NewYearCampaignSale(Game game, Gamer gamer)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Oyun Id: " + game.GameId + " Oyun Adı: " + game.GameName +
                " Oyun Türü: " + game.Type + " Oyun Fiyatı: " + ((game.Price) - (game.Price) * 75 / 100) + "$ " +
                gamer.GamerFirstName + " " + gamer.GamerLastName + " oyuncuya satıldı." + "\n");
        }
    }
}
