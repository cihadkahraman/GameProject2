using Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Abstract
{
    public interface ISellerManager
    {
        public void AddSell(Game game, Gamer gamer,Campaign campaign);

        public void GetSellsByGameId(Game game);

        public void GetSellsByGamerId(Gamer gamer);
    }
}
