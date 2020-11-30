using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int[] NumberArr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] Names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            bool[] TruFal = new bool[] { true, false, true, false, true, false, true, false, true, false };

            List<string> IceCream = new List<string>();

            IceCream.Add("Chocolate");
            IceCream.Add("Vanilla");
            IceCream.Add("Coconut");
            IceCream.Add("Strawberry");
            IceCream.Add("Walnut");

            Console.WriteLine(IceCream.Count);
            Console.WriteLine(IceCream[2]);
            IceCream.RemoveAt(2);
            Console.WriteLine(IceCream.Count);

            Dictionary<string, string> Profiles = new Dictionary<string, string>();

            foreach (string name in Names)
            {
                Profiles.Add(name, IceCream[rand.Next(4)]);
            }

            foreach (KeyValuePair<string, string> entry in Profiles)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }

        }
    }
}
