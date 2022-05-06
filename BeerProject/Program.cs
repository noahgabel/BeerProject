using System;

namespace BeerProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Beer[] beers = new Beer[2];

            Beer beer1 = new Beer("Heineken", "IPA", BeerType.MIX, 25, 5.5);
            beers[0] = beer1;
            Beer beer2 = new Beer("Tuborg", "Slaveøl", BeerType.LAGER, 25, 10.5);
            beers[1] = beer2;
            Array.Sort(beers);
            foreach (var beer in beers)
            {
                Console.WriteLine(beer.ToString());
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("New volume of the beers: " + beer1.Add(beer2).volume + " cl");
            Beer beer3 = beer1.Mix(beer2);
            Console.WriteLine(beer3.ToString());
        }
    }
}