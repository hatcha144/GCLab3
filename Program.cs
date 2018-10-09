using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab3
{
    class Program
    {
        static void Main(string[] args)

        {
            string name; 
            string restart;
            
                Console.WriteLine("Please enter your first name: ");
                name = Console.ReadLine();
               do {
                
               Console.WriteLine(name + ", enter a whole number between 1 and 100");

                int userNum = Int32.Parse(Console.ReadLine());

                if (userNum >= 100 || userNum <= 1)

                {
                    Console.WriteLine(name + ", that is not a whole number between 1 and 100!");
                }

                else if (userNum % 2 == 1)
                {
                    Console.WriteLine(userNum + " is odd");
                }
                else if (userNum % 2 == 0 && userNum <= 25)
                {
                    Console.WriteLine(userNum + " is even and less than 25");
                }
                else if (userNum % 2 == 0 && userNum <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (userNum % 2 == 0 && userNum > 60)
                {
                    Console.WriteLine(userNum + " is even");
                }
                else if (userNum % 2 == 1 && userNum > 60)
                {
                    Console.WriteLine(userNum + "is odd");
                }

              
                Console.WriteLine(name + ", would you like to restart? (Y or N)");


                restart = Console.ReadLine();

                
            } while (restart.ToLower() == "y");
















        }
         
    }
}
