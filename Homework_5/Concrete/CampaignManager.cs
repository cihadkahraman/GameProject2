using Homework_5.Abstract;
using Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void SaveCampaign(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Kampanya eklendi\n");
        }
        public void DeleteCampaign(int campaignId)
        {
            int _findIndex = campaigns.FindIndex(x => x.CampaignId == campaignId);
            campaigns.Remove(campaigns[_findIndex]);
            Console.WriteLine("Kampanya silindi\n");

        }

        public void List()
        {
            foreach (var i in campaigns)
            {
                Console.WriteLine("Kampanya adı: " + i.CampaignName + " Kampanya indirim oranı: %" + i.DiscountRate);
            }
        }

        public Campaign PickCampaign(int campaignId)
        {
            Campaign campaign1 = campaigns.Find(x => x.CampaignId == campaignId);
            return campaign1;
        }


    }
}
