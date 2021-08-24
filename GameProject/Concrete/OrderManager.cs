using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void CampaignOrder(Gamer gamer, Game game, Campaign campaign)
        {
            decimal discountRate = game.GamePrice - (game.GamePrice * campaign.DiscountRate);
            Console.WriteLine("Discount rate : "+ discountRate);
        }

        public void Order(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Buy : " + game.GameName + "  " + game.GamePrice + " TL ");
        }
    }
}
