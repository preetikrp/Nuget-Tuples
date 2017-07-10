using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;


namespace Nuget_Tuples
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("apples", 2.50, 2));
            transactions.Add(("mangos", 3.50, 4));
            transactions.Add(("bananas", 4.50, 6));
            transactions.Add(("grapes", 5.50, 8));
            transactions.Add(("pineapples", 6.50, 10));
            double totalAmount = 0;
            int totalQuantity = 0;

            foreach ((string product, double amount, int quantity) t in transactions) {

                // Logic goes here to look up quantity and amount in each transaction
                totalAmount = totalAmount + t.amount;
                totalQuantity = totalQuantity + t.quantity;

            }
            Console.WriteLine("Total amount: " + totalAmount);
            Console.WriteLine("Total quantity: " + totalQuantity);
            Console.ReadLine();

        }
    }

}
