using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Order(Gamer gamer,Game game);
        void CampaignOrder(Gamer gamer, Game game, Campaign campaign);
    }
}
