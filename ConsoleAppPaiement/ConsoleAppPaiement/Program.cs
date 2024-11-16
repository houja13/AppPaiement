using ConsoleAppPaiement;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carteCredit1 = new CarteCredit(5000, "shoping", 1234);
        CarteCredit carteCredit2 = new CarteCredit(4000, "shoping", 5678);
        CarteCredit carteCredit3 = new CarteCredit(3000, "shoping", 9012);
    }
}