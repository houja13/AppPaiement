using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiement
{
    internal class Paypal :Paiement
    {
        public string Courriel { get; set; }

        public Paypal(double montant, string description, string courriel) : base(montant, description)
        {
            Courriel = courriel;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"le montant est {Montant}. Description du montant {Description} et le Courriel est {Courriel}.");
        }

    }
}
