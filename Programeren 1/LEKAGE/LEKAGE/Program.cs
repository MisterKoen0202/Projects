using System;

namespace LEKAGE
{
    class Program
    {

        const double UREN_IN_WEEK = 168;
        const double CC_in_L = 1000;
        static void Main(string[] args)


        {
            Console.Write("Geef de hoeveelheid cc lekage per uur: ");
            string invoer = Console.ReadLine();
            double cc_per_uur = double.Parse(invoer);
            double cc_per_week = cc_per_uur * UREN_IN_WEEK;
            double L_per_week = cc_per_week / CC_in_L;

            Console.WriteLine("Aantal Liter per week: " + L_per_week



        }
    }
}
