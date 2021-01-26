using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleRoom
{
    public interface ISalesManager
    {
        void GameList(Game[] games);

        void WeekendCampaign(Game game);
        void BlackFridayCampaign(Game game);
        void NewYearCampaign(Game game);

        void WeekendCampaignSale(Game game,Gamer gamer);

        void BlackFridayCampaignSale(Game game, Gamer gamer);

        void NewYearCampaignSale(Game game, Gamer gamer);

    }
}
