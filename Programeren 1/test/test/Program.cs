using System;

namespace test
{
    class Program
    {
        const double LITERPRIJS = 1.78;
        static void Main(string[] args)
        {
            Console.Write("Geef het aantal liters getankt: ");
            string invoer = Console.ReadLine();

            double aantalLiters = double.Parse(invoer);

            double bedrag = aantalLiters * LITERPRIJS;

            Console.WriteLine("Het bedrag is: " + bedrag);


        }
    }
}
