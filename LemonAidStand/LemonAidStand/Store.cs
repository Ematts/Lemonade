using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Store
    {
        public double lemonPrice = 0.10;
        public double lemonPurchase;
        public double icePrice = 0.05;
        public double icePurchase;
        public double sugarPrice = 0.18;
        public double sugarPurchase;
        public double cupPrice = 0.04;
        public double cupPurchase;

        Player player = new Player();

        public void storeFront()
        {
            Console.WriteLine("Please place your supplie order.");
            Console.WriteLine("Money: " + player.money + " Lemons: " + player.lemonCount + "Icecubes: " + player.iceCount + "Cups of sugar: " + player.sugarCount + "Cups: " + player.cupCount);
        }
        public Store()
        {


        }

        public double getLemons()
        {
            Console.WriteLine("How many lemons do you want?");
            lemonPurchase = double.Parse(Console.ReadLine());


            return lemonPurchase;

        }

        public double getIce()
        {
            Console.WriteLine("How much ice do you want?");
            icePurchase = double.Parse(Console.ReadLine());


            return icePurchase;

        }
        public double getSugar()
        {
            Console.WriteLine("How much sugar do you want?");
            sugarPurchase = double.Parse(Console.ReadLine());


            return sugarPurchase;

        }
        public double getCups()
        {
            Console.WriteLine("How many cups do you want?");
            cupPurchase = double.Parse(Console.ReadLine());


            return cupPurchase;

        }

        public double lemonCalc()
        {

            if ((lemonPurchase * lemonPrice) <= player.money)
            {

                player.lemonCount += lemonPurchase;
                player.money -= lemonPurchase * lemonPrice;
                Console.WriteLine("You now have " + player.lemonCount + " lemons.");

                return player.lemonCount;
            }

            else
            {

                Console.WriteLine("You don't have enough money for this purchase");
                return player.lemonCount;
            }

       }
       public double iceCalc()
        {

            if ((icePurchase * icePrice) <= player.money)
            {

                player.iceCount += icePurchase;
                player.money -= icePurchase * icePrice;
                Console.WriteLine("You now have " + player.iceCount + " cubes of ice.");

                return player.iceCount;
            }

            else
            {

                Console.WriteLine("You don't have enough money for this purchase");
                return player.iceCount;
            }

        }
        public double sugarCalc()
        {

            if ((sugarPurchase * sugarPrice) <= player.money)
            {

                player.sugarCount += sugarPurchase;
                player.money -= sugarPurchase * sugarPrice;
                Console.WriteLine("You now have " + player.sugarCount + " cups of sugar.");
           
                return player.sugarCount;
            }

            else
            {

                Console.WriteLine("You don't have enough money for this purchase");
                return player.sugarCount;
            }

        }
        public double cupCalc()
        {

            if ((cupPurchase * cupPrice) <= player.money)
            {

                player.cupCount += cupPurchase;
                player.money -= cupPurchase * cupPrice;
                Console.WriteLine("You now have " + player.cupCount + " cups.");

                return player.cupCount;
            }

            else
            {

                Console.WriteLine("You don't have enough money for this purchase");
                return player.cupCount;
            }

        }
    }
    }
