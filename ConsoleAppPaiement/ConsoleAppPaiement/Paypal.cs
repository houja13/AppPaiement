using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiement
{
    internal class Paypal : Paiement
    {
        public string Courriel {  get; set; }
        public Paypal(double montant, string description, string courriel) : base(double montant, string description) 
        {
            Courriel = courriel;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"le montant {Montant}, la description {Description} et la courriel {Courriel}");
        }
    }
}
