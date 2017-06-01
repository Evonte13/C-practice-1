using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats up? Tell me your First name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Hello "  + firstName);
            Console.WriteLine(firstName + " whats your lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine( firstName + lastName  );

            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();

            Console.WriteLine("whats your fav movie");
            string movie = Console.ReadLine();

            


            
            


        }
    }
}
