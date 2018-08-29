using System;
using System.Collections.Generic;


namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty HashSet named Showroom that will contain strings.

            HashSet<string> Showroom = new HashSet<string> { };
            // Add four of your favorite car model names to the set.
            Showroom.Add("Element");
            Showroom.Add("CRV");
            Showroom.Add("Pilot");
            Showroom.Add("Prius");

            // Print to the console how many cars are in your show room.
            Console.WriteLine(Showroom.Count);

            // Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Element");

            // Print your showroom again, and notice how there's still only one representation of that model in there.
            foreach (String model in Showroom)
            {
                Console.WriteLine(model);
            }

            // Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string> { };
            UsedLot.Add("Model X");
            UsedLot.Add("Model S");

            // Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);
            foreach (String model in Showroom)
            {
                Console.WriteLine(model);
            }
            // You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("Pilot");
            Console.WriteLine("finished list:");
            foreach (String model in Showroom)
            {
                Console.WriteLine(model);
            }


        }
    }
}
