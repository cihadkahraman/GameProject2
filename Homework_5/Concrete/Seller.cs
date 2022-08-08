using Homework_5.Abstract;
using Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Concrete
{
    public class Seller : ISellerManager
    {
        List<Sell> sells = new List<Sell>();
        public void AddSell(Game game, Gamer gamer,Campaign campaign)
        {
            Sell sell = new Sell();
            sell.GameId = game.Id;
            sell.GamerNationalId = gamer.NationalId;
            sells.Add(sell);
        }

        public void GetSellsByGameId(Game game)
        {
            List<Sell> sells1 = new List<Sell>();
            sells1 = sells.FindAll(x => x.GameId == game.Id);
            Console.WriteLine(game.GameName + " oyununa sahip olan oyuncuların kimlik numaraları: ");
            foreach (Sell sell in sells1)
            {
                Console.WriteLine(sell.GamerNationalId);
            }
        }

        public void GetSellsByGamerId(Gamer gamer)
        {
            List<Sell> sells1 = new List<Sell>();
            sells1 = sells.FindAll(x => x.GamerNationalId == gamer.NationalId);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusunun sahip olduğu oyunların barkod numaraları: ");
            foreach (Sell sell in sells1)
            {
                Console.WriteLine(sell.GameId);
            }
        }
    }
}
