using Game.Abstract;
using Game.Concrete;
using Game.Entities;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() {FirstName = "Kaan",LastName = "Monun",BirthYear = 1998,NationalityId = "1332444567" };
            Campaign campaign = new Campaign() {CampaignName ="Black Friday",CampaignDuration ="1 yıl",DiscountPrice = 20 };
            Product product = new Product() {GameName = "Fifa21",GameCategory ="Sport",GamePrice = 350 };
            IPlayerManager playerManager = new PlayerManager();
            playerManager.Add(customer);
            
            ICampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            Console.WriteLine("///////////////////");
            ISalesManager salesManager = new SalesManager();
            salesManager.Sell(customer, product);
            salesManager.GetProduct(product,campaign);
            Console.WriteLine("///////////////////");





        }
    }
}
