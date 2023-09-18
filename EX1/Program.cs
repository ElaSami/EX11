using System;

namespace EX1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            double montant, tps, tvq, total;

            do
            {
                Console.WriteLine("Veuillez entrer le montant que vous souhaitez calculer la taxe : ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out montant))
                {
                    tps = montant * 0.05;
                    tvq = montant * 0.09975;
                    total = montant + tps + tvq;
                    Console.WriteLine("Montant : " + montant.ToString("C"));
                    Console.WriteLine("TPS (5%) : " + tps.ToString("C"));
                    Console.WriteLine("TVQ (9,975%) : " + tvq.ToString("C"));
                    Console.WriteLine("TOTAL : " + total.ToString("C"));
                    break; 
                }
                else
                {
                    Console.WriteLine("Erreur : Entrée invalide. Veuillez entrer un nombre valide.");
                }
            } while (true);
        }
    }
}
