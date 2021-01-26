using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class SalesManager:ISalesManager
    {
        int newPrice;
        public void Sell(Customer customer, Product product)
        {

            Console.WriteLine(customer.FirstName + " : " + product.GameName);
            Console.WriteLine("Satılan Oyunun kategorisi:" + product.GameCategory);
            Console.WriteLine("Oyunun kampanyasız fiyatı:" + product.GamePrice);

        }
        public void GetProduct(Product product, Campaign campaign)
        {

            newPrice = product.GamePrice - campaign.DiscountPrice;

            Console.WriteLine("Oyuna uygulanan kampanya : " + campaign.CampaignName);
            Console.WriteLine("Oyunun kampanyalı fiyatı : " + newPrice);

        }




    }
}
