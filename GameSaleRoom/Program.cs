using System;

namespace GameSaleRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameId = 1;
            game.GameName = "GTA 5";
            game.Type = "Aksiyon";
            game.Price = 150;

            Game forza = new Game();
            forza.GameId = 2;
            forza.GameName = "Forza Horizon 4";
            forza.Type = "Yarış";
            forza.Price = 400;

            Gamer gamer = new Gamer();
            gamer.GamerId = 1;
            gamer.GamerFirstName = "Furkan Berk";
            gamer.GamerLastName = "Akdas";
            gamer.DateOfBirthday = new DateTime(1996, 3, 26);
            gamer.NationalId = "34234212";

            int select;
            int campaign;
            int campaignSale;
            bool exit = true;

            EDevletCheckService eDevletCheck = new EDevletCheckService();
            eDevletCheck.CheckIFGamer(gamer);



            while (exit)
            {
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Listeden Seçiniz");
                Console.WriteLine("1)Oyunları Listeleyiniz");
                Console.WriteLine("2)Kampanya İşlemleri");
                Console.WriteLine("3)Kampanyaları Görüntüleyin");
                Console.WriteLine("4)Oyun satın al");
                Console.WriteLine("5)Çıkış");
                select = Convert.ToInt16(Console.ReadLine());

                if(select == 1)
                {
                    Game[] games = new Game[] { game, forza };
                    GameSale sale = new Game();
                    sale.GameList(games);
                }
                else if(select == 2)
                {
                    Console.WriteLine("1)Kampanya Ekle");
                    Console.WriteLine("2)Kampanya Sil");
                    Console.WriteLine("3)Kampanya Güncelle");
                    campaign = Convert.ToInt16(Console.ReadLine());
                    if(campaign == 1)
                    {
                        GameCampaign gameCampaign = new GameCampaign();
                        gameCampaign.Add(game);
                    }
                    else if(campaign == 2)
                    {
                        GameCampaign gameCampaign = new GameCampaign();
                        gameCampaign.Delete(game);

                    }
                    else if (campaign == 3)
                    {
                        GameCampaign gameCampaign = new GameCampaign();
                        gameCampaign.Update(game);
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir seçim yoktur");
                    }
                }
                else if(select == 3)
                {
                    Console.WriteLine("Kampanya Türleri");
                    Console.WriteLine("1)Weekend");
                    Console.WriteLine("2)Black Friday");
                    Console.WriteLine("3)New Year");
                    campaign = Convert.ToInt16(Console.ReadLine());
                    if(campaign == 1)
                    {
                        GameSale gameSale = new Game();
                        gameSale.WeekendCampaign(game);
                    }
                    else if(campaign == 2)
                    {
                        GameSale gameSale = new Game();
                        gameSale.BlackFridayCampaign(game);
                    }
                    else if(campaign == 3)
                    {
                        GameSale gameSale = new Game();
                        gameSale.NewYearCampaign(game);
                    }
                   
                    else
                    {
                        Console.WriteLine("Böyle bir kampanya yok");
                    }
                }
                else if (select == 4)
                {
                    Console.WriteLine("Satış İşlemi");
                    Console.WriteLine("1)Weekend indirimi ile oyunu al");
                    Console.WriteLine("2)Black Friday indirimi ile oyunu al");
                    Console.WriteLine("3)New Year indirimi ile oyunu al");
                    campaignSale = Convert.ToInt16(Console.ReadLine());
                    if(campaignSale == 1)
                    {
                        GameSale gameSale = new Game();
                        gameSale.WeekendCampaignSale(game,gamer);
                    }
                    else if(campaignSale == 2)
                    {
                        GameSale gameSale = new Game();
                        gameSale.BlackFridayCampaignSale(game, gamer);
                    }
                    else if (campaignSale == 3)
                    {
                        GameSale gameSale = new Game();
                        gameSale.NewYearCampaignSale(game, gamer);
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir satış yok");
                    }
                }
                else if(select == 5)
                {
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Böyle bir seçim yok");
                }

            }

            Console.ReadKey();
        }
    }
}
