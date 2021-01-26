using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " eklendi ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " süresi bitti ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "güncellendi");
        }
    }
}
