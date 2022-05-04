using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private object MessageBox;
    // tableaux de données nécessaires au calcul de l'impôt
    // Si vous souhaitez qu'un littéral numérique réel soit considéré 
    // comme une valeur de type decimal, utilisez le suffixe m ou M

    decimal[] limites = { 4962M, 8382M, 14753M, 23888M, 38868M, 47932M, 0M };
    decimal[] coeffR = { 0M, 0.068M, 0.191M, 0.283M, 0.374M, 0.426M, 0.481M };
    decimal[] coeffN = { 0M, 291.09M, 1322.92M, 2668.39M, 4846.98M, 6883.66M, 9505.54M };


    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonQUITTERClicked(object sender, EventArgs e)
    {
        Application.Quit();

    }

    protected void effacer(object sender, EventArgs e)
    {
        SalaireAnnuel.Text = "";
        //initialisation our "numericUpDown" to 0
        nbr_enfants.Value = 0;
        Impot_pay.Text = "";
        radiobutton_oui.Active = true;
    }

    protected void calculer(object sender, EventArgs e)
    {
        if ((SalaireAnnuel.Text == ""))
        {
            MessageDialog md = new MessageDialog(this,
                DialogFlags.DestroyWithParent, MessageType.Warning,
                ButtonsType.Close, "Veuillez entrer une valeur dans salaire");
            md.Run();
            md.Destroy();
        }
        else
        {
            double nbEnfants = nbr_enfants.Value;
            decimal nbParts;

            //Si Marié(e)
            if (radiobutton_oui.Active)
                nbParts = (decimal)nbEnfants / 2 + 2;
            //si Célibataire
            else nbParts = (decimal)nbEnfants / 2 + 1;
            if (nbEnfants >= 3) nbParts += 0.5M;

            // revenu imposable
            decimal revenu = 0.72M * Convert.ToDecimal(SalaireAnnuel.Text);

            // quotient familial
            decimal QF = revenu / nbParts;

            //la méthode Math.Round permet de limiter le nrb apres la virgule
            NombreParts.Text = Convert.ToString(Math.Round(nbParts, 2));
            RevenueImpo.Text = Convert.ToString(Math.Round(revenu, 2));
            SalaireAnnu.Text = Convert.ToString(Math.Round(QF, 2));


            // recherche de la tranche d'impots correspondant à QF
            int i;
            int nbTranches = limites.Length;
            limites[nbTranches - 1] = QF;
            i = 0;
            while (QF > limites[i]) i++;
            // l'impôt
            Decimal impots = (Decimal)(coeffR[i] * revenu - coeffN[i] * nbParts);

            Impot_pay.Text = (Math.Round(impots, 2)).ToString() + " DH";
        }
    }

}
