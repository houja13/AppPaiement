using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiement
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }
        
        public CarteCredit(double montant, string description,int cartecredi) : base(double montant, string description)
        {
            NumeroCarte = cartecredi;
        }
        public override void AfficherDetails() 
        {
            Console.WriteLine($"le montant {Montant}, la description {Description} et la carte {NumeroCarte}");
        }
    }
}
