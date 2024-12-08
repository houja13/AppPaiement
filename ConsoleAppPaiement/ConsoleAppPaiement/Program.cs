using ConsoleAppPaiement;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carteCredit1 = new CarteCredit(500,"shoping",12345);
        CarteCredit carteCredit2 = new CarteCredit(400, "SPA", 12367);
        CarteCredit carteCredit3 = new CarteCredit(300, "Restaut", 12389);
    }
}