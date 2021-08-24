using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                NationalityId = "123456",
                FirstName="HAKKI",
                LastName="KARAKAŞ",
                UserName="Best",
                DateOfBirth=new DateTime(1992,1,1)
            };

            Gamer gamer2 = new Gamer
            {

                Id = 2,
                NationalityId = "123456",
                FirstName = "HAKKI2",
                LastName = "KARAKAŞ2",
                UserName = "Best2",
                DateOfBirth = new DateTime(1992, 1, 1)
            };
            List<Gamer> gamers = new List<Gamer> { gamer1, gamer2 };
            foreach (var gamer in gamers)
            {
                gamerManager.Add(gamer);
            }

            CampaignManager campaingManager = new CampaignManager();
            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "  %40 Discount ", DiscountRate = 0.60M };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "  %30 Discount ", DiscountRate = 0.80M };
            List<Campaign> campaigns = new List<Campaign> { campaign1,campaign2};
            foreach (var campaign in campaigns)
            {
                campaingManager.Add(campaign);
             }

            GameManager gameManager = new GameManager();
            Game game1 = new Game { Id = 1, GameName = "Game1 ", GamePrice = 110 };
            Game game2 = new Game { Id = 2, GameName = "Game2  ", GamePrice = 120 };

            gameManager.Add(game2);
            gameManager.Update(game1);

     

            OrderManager orderManager = new OrderManager();

            orderManager.CampaignOrder(gamer1, game1, campaign2);
            orderManager.Order(gamer2, game2);



        }
    }
}
