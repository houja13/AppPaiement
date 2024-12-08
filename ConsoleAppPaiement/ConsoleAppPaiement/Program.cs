using ConsoleAppPaiement;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carteCredit1 = new CarteCredit(500,"shoping",12345);
        CarteCredit carteCredit2 = new CarteCredit(400, "SPA", 12367);
        CarteCredit carteCredit3 = new CarteCredit(300, "Restaut", 12389);


        Paypal paypal1 = new Paypal(2000,"Rent","hajar@gmail.com");
        Paypal paypal2 = new Paypal(4000,"Loisir","Nour@hotmail.com");



        Utilisateur utilisateur = new Utilisateur("Hajar");

        utilisateur.AjouterPaiement(carteCredit1);
        utilisateur.AjouterPaiement(carteCredit2);
        utilisateur.AjouterPaiement(carteCredit3);
        utilisateur.AjouterPaiement(paypal1);
        utilisateur.AjouterPaiement(paypal2);

        utilisateur.AfficherInfos();
    }
}