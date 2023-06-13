using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrate
{
    public class CampaignManager : ICampaignService
    {
        public void Create(Campaign campaign)
        {
            Console.WriteLine("Kampanya oluşturuldu."+ campaign.Baslangıc+" günü başlıyor"+" "+ campaign.Bitis+ ""+ "günü bitiyor.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya oluşturuldu.");
        }
    }
}
