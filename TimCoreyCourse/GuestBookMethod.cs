using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookMethod
{
    public static class GBMeth
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello Guest.");
        }

        public static (string, int) AskNameAndParty()
        {
            Console.Write("Whats your surname?: ");
            string name = Console.ReadLine();
            Console.Write($"Hello the {name}'s, how many people are in your party?");
            int partySize = Convert.ToInt32(Console.ReadLine());
            return (name, partySize);
        }

        public static bool MoreGuests()
        {
            Console.WriteLine("Are there more guests to check in? (y/n)" );
            string inputAdd = Console.ReadLine();
            if (inputAdd.ToLower() == "y") { return true; }
            else if (inputAdd.ToLower() == "n") { return false; }
            else { Console.WriteLine("invalid input returning false."); return false; }
        }

        public static void GuestsAndTotalGuests(Dictionary<string, int> guests)
        {
            int totalGuests = 0;
            foreach (KeyValuePair<string, int> guest in guests)
            {
                Console.WriteLine($"The {guest.Key} party is here.");
                totalGuests += guest.Value;
            }
            Console.WriteLine($"There are {totalGuests} in attendance.");
        }
    }
}
