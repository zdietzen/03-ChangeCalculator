using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EASILY BREAKABLE 
namespace _03_ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
                try{ 
            Console.WriteLine("Change-A-Nator v1.0");
            Console.WriteLine("*******************");
            //User inputs the total cost and amount paid and converts the input to a decimal
           
                
                    Console.WriteLine("What is the Total Price?");
                    Console.Write("$");
                    decimal x = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("What is the amount paid?");
                    Console.Write("$");
                    decimal y = Convert.ToDecimal(Console.ReadLine());
                    //and this calculates your change
                    Console.WriteLine("Change Due");
                    Console.Write("$");
                    Console.WriteLine(y - x);

                    decimal change = y - x;
                    Console.WriteLine("___________________");
                    //This tells you how many of each coin to despense. 
                    decimal numberOfQuarters = Math.Floor(change / 0.25M);
                    decimal numberOfQuartersAfter = Math.Floor(numberOfQuarters % 4);
                    decimal numberOfDimes = Math.Floor((change % 0.25M) / 0.10M);
                    decimal numberOfNickles = Math.Floor(((change % 0.25M) % 0.10M / 0.05M));
                    decimal numberOfPennies = Math.Floor((((change % 0.25M) % 0.10M % 0.05M / 0.01M)));

                    Console.WriteLine(("# of Quarters = {0}"), Math.Round(numberOfQuartersAfter, 2));
                    Console.WriteLine(("# of Dimes = {0}"), Math.Round(numberOfDimes, 2));
                    Console.WriteLine(("# of Nickles = {0}"), Math.Round(numberOfNickles, 2));
                    Console.WriteLine(("# of Pennies = {0}"), Math.Round(numberOfPennies, 2));
                }
                finally
                {
                    Console.WriteLine("Press Enter for New Transaction");
                    Console.ReadLine();
                    Console.Clear();
                }
                        
        
        }

    }
}