using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class PlayerManager : IPlayerManager
    {

      
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kullanıcı eklendi ");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kullanıcı silindi ");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kullanıcı güncellendi ");
        }
    }
}
