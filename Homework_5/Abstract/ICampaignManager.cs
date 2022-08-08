using System;
using System.Collections.Generic;
using System.Text;
using Homework_5.Entities;
namespace Homework_5.Abstract
{
    public interface ICampaignManager
    {
        void SaveCampaign(Campaign campaign);
        void DeleteCampaign(int campaignId);
        void List();
        Campaign PickCampaign(int campaignId);
    }
}
