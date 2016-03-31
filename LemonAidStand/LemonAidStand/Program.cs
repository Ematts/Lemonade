using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Program
    {
        static void Main(string[] args)

        {
            Game game = new Game();
            game.getCustomers();
            List<Customer> customerList = new List<Customer>();
            Console.ReadKey();
        }
    }
}
