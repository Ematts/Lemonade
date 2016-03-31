using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Game
    {
        Player player = new Player();
        Weather weather = new Weather();
        Inventory ineventory = new Inventory();
        Store store = new Store();
        int customerTotal = 50;
        List<Customer> customerList = new List<Customer>();
        List<Customer> buyerList = new List<Customer>();
        double priceDemand;
        Random rndCustomer = new Random();
        Random rndMood = new Random();
        double weatherDemand;
        double totalDemand;
        double buyerIndex;

        public List<Customer> getCustomers()
        {

            for (int customerAmount = 0; customerAmount < customerTotal; customerAmount++)
            {
                Customer customer = new Customer(rndMood.Next(0, 4));
                customerList.Add(customer);
            }
            return customerList;

        }

        public double getTotalDemand()

        {

            weatherDemand = weather.getWeatherDemand();
            priceDemand = player.getGlassPrice();
            totalDemand = weatherDemand / priceDemand;
            return totalDemand;

        }

        public List<Customer> getBuyers()
        {
            foreach (Customer customer in customerList)
            {
                buyerIndex = customer.moodNumber * totalDemand;

                if (buyerIndex >= 420)

                {
                    buyerList.Add(customer);
                    
                }

            }
            return buyerList;
        }

    }
}
               


            


           
       

    


