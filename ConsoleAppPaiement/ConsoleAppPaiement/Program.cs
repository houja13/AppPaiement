using ConsoleAppPaiement;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carteCreditH = new CarteCredit(500,"shoping",12345);
        CarteCredit carteCreditN = new CarteCredit(400, "SPA", 12367);
        CarteCredit carteCreditJ = new CarteCredit(300, "Restaut", 12389);


        Paypal paypalH = new Paypal(2000,"Rent","hajar@gmail.com");
        Paypal paypalN = new Paypal(4000,"Loisir","Nour@hotmail.com");



        Utilisateur utilisateur = new Utilisateur("Hajar");

        utilisateur.AjouterPaiement(carteCreditH);
        utilisateur.AjouterPaiement(carteCreditN);
        utilisateur.AjouterPaiement(carteCreditJ);
        utilisateur.AjouterPaiement(paypalH);
        utilisateur.AjouterPaiement(paypalN);

        utilisateur.AfficherInfos();
    }
}