using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added : " +campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted : "+campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated : "+campaign.CampaignName);
        }
    }
}
