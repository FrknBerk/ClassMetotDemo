using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleRoom
{
    class EDevletCheckService : ICheckService
    {
        public void CheckIFGamer(Gamer gamer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (gamer.GamerFirstName == "Furkan Berk" && gamer.GamerLastName == "Akdas")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız");
            }
        }


    }
}
