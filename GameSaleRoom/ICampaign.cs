using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleRoom
{
    public interface ICampaign
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
