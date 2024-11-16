using ConsoleAppPaiement;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carteCredit1 = new CarteCredit(5000, "shoping", 1234);
        CarteCredit carteCredit2 = new CarteCredit(4000, "makeup", 5678);
        CarteCredit carteCredit3 = new CarteCredit(3000, "achat", 9012);

        Paypal paypal1 = new Paypal(500, "vendre", "hajar@gmail.com");
        Paypal paypal2 = new Paypal(400, "donnation", "nour@gmail.com");
    }
}