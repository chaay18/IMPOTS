
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed_impots;

	private global::Gtk.Label label_enfants;

	private global::Gtk.Label label_salaire;

	private global::Gtk.Label label_marie;

	private global::Gtk.RadioButton radiobutton_oui;

	private global::Gtk.RadioButton radiobutton_non;

	private global::Gtk.SpinButton nbr_enfants;

	private global::Gtk.Entry SalaireAnnuel;

	private global::Gtk.Button button_CALC;

	private global::Gtk.Button button_EFFACER;

	private global::Gtk.Button button_QUITTER;

	private global::Gtk.Entry RevenueImpo;

	private global::Gtk.Entry NombreParts;

	private global::Gtk.Entry SalaireAnnu;

	private global::Gtk.Label label6;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.Label label4;

	private global::Gtk.Entry Impot_pay;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed_impots = new global::Gtk.Fixed();
		this.fixed_impots.Name = "fixed_impots";
		this.fixed_impots.HasWindow = false;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.label_enfants = new global::Gtk.Label();
		this.label_enfants.Name = "label_enfants";
		this.label_enfants.LabelProp = global::Mono.Unix.Catalog.GetString("nombre d\'enfants");
		this.fixed_impots.Add(this.label_enfants);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.label_enfants]));
		w1.X = 68;
		w1.Y = 69;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.label_salaire = new global::Gtk.Label();
		this.label_salaire.Name = "label_salaire";
		this.label_salaire.LabelProp = global::Mono.Unix.Catalog.GetString("Salaire Annuel");
		this.fixed_impots.Add(this.label_salaire);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.label_salaire]));
		w2.X = 68;
		w2.Y = 115;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.label_marie = new global::Gtk.Label();
		this.label_marie.Name = "label_marie";
		this.label_marie.LabelProp = global::Mono.Unix.Catalog.GetString("Est-vous marié ?");
		this.fixed_impots.Add(this.label_marie);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.label_marie]));
		w3.X = 68;
		w3.Y = 17;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.radiobutton_oui = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("OUI"));
		this.radiobutton_oui.CanFocus = true;
		this.radiobutton_oui.Name = "radiobutton_oui";
		this.radiobutton_oui.DrawIndicator = true;
		this.radiobutton_oui.UseUnderline = true;
		this.radiobutton_oui.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.fixed_impots.Add(this.radiobutton_oui);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.radiobutton_oui]));
		w4.X = 245;
		w4.Y = 10;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.radiobutton_non = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("NON"));
		this.radiobutton_non.CanFocus = true;
		this.radiobutton_non.Name = "radiobutton_non";
		this.radiobutton_non.DrawIndicator = true;
		this.radiobutton_non.UseUnderline = true;
		this.radiobutton_non.Group = this.radiobutton_oui.Group;
		this.fixed_impots.Add(this.radiobutton_non);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.radiobutton_non]));
		w5.X = 397;
		w5.Y = 10;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.nbr_enfants = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.nbr_enfants.CanFocus = true;
		this.nbr_enfants.Name = "nbr_enfants";
		this.nbr_enfants.Adjustment.PageIncrement = 10D;
		this.nbr_enfants.ClimbRate = 1D;
		this.nbr_enfants.Numeric = true;
		this.fixed_impots.Add(this.nbr_enfants);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.nbr_enfants]));
		w6.X = 247;
		w6.Y = 64;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.SalaireAnnuel = new global::Gtk.Entry();
		this.SalaireAnnuel.CanFocus = true;
		this.SalaireAnnuel.Name = "SalaireAnnuel";
		this.SalaireAnnuel.IsEditable = true;
		this.SalaireAnnuel.InvisibleChar = '●';
		this.fixed_impots.Add(this.SalaireAnnuel);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.SalaireAnnuel]));
		w7.X = 247;
		w7.Y = 109;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.button_CALC = new global::Gtk.Button();
		this.button_CALC.CanFocus = true;
		this.button_CALC.Name = "button_CALC";
		this.button_CALC.UseUnderline = true;
		this.button_CALC.Label = global::Mono.Unix.Catalog.GetString("CALCULER");
		this.fixed_impots.Add(this.button_CALC);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.button_CALC]));
		w8.X = 33;
		w8.Y = 190;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.button_EFFACER = new global::Gtk.Button();
		this.button_EFFACER.CanFocus = true;
		this.button_EFFACER.Name = "button_EFFACER";
		this.button_EFFACER.UseUnderline = true;
		this.button_EFFACER.Label = global::Mono.Unix.Catalog.GetString("EFFACER");
		this.fixed_impots.Add(this.button_EFFACER);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.button_EFFACER]));
		w9.X = 223;
		w9.Y = 190;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.button_QUITTER = new global::Gtk.Button();
		this.button_QUITTER.CanFocus = true;
		this.button_QUITTER.Name = "button_QUITTER";
		this.button_QUITTER.UseUnderline = true;
		this.button_QUITTER.Label = global::Mono.Unix.Catalog.GetString("QUITTER");
		this.fixed_impots.Add(this.button_QUITTER);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.button_QUITTER]));
		w10.X = 416;
		w10.Y = 190;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.RevenueImpo = new global::Gtk.Entry();
		this.RevenueImpo.CanFocus = true;
		this.RevenueImpo.Name = "RevenueImpo";
		this.RevenueImpo.IsEditable = false;
		this.RevenueImpo.InvisibleChar = '●';
		this.fixed_impots.Add(this.RevenueImpo);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.RevenueImpo]));
		w11.X = 226;
		w11.Y = 300;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.NombreParts = new global::Gtk.Entry();
		this.NombreParts.CanFocus = true;
		this.NombreParts.Name = "NombreParts";
		this.NombreParts.IsEditable = false;
		this.NombreParts.InvisibleChar = '●';
		this.fixed_impots.Add(this.NombreParts);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.NombreParts]));
		w12.X = 226;
		w12.Y = 260;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.SalaireAnnu = new global::Gtk.Entry();
		this.SalaireAnnu.CanFocus = true;
		this.SalaireAnnu.Name = "SalaireAnnu";
		this.SalaireAnnu.IsEditable = false;
		this.SalaireAnnu.InvisibleChar = '●';
		this.fixed_impots.Add(this.SalaireAnnu);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.SalaireAnnu]));
		w13.X = 226;
		w13.Y = 340;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre de Parts");
		this.fixed_impots.Add(this.label6);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.label6]));
		w14.X = 100;
		w14.Y = 267;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Revenu Imposable");
		this.fixed_impots.Add(this.label1);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.label1]));
		w15.X = 100;
		w15.Y = 305;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Salaire Annuel");
		this.fixed_impots.Add(this.label2);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.label2]));
		w16.X = 100;
		w16.Y = 347;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Impots à payer ");
		this.fixed_impots.Add(this.label4);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.label4]));
		w17.X = 100;
		w17.Y = 387;
		// Container child fixed_impots.Gtk.Fixed+FixedChild
		this.Impot_pay = new global::Gtk.Entry();
		this.Impot_pay.CanFocus = true;
		this.Impot_pay.Name = "Impot_pay";
		this.Impot_pay.IsEditable = false;
		this.Impot_pay.InvisibleChar = '●';
		this.fixed_impots.Add(this.Impot_pay);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed_impots[this.Impot_pay]));
		w18.X = 226;
		w18.Y = 380;
		this.Add(this.fixed_impots);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 516;
		this.DefaultHeight = 430;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button_CALC.Clicked += new global::System.EventHandler(this.calculer);
		this.button_EFFACER.Clicked += new global::System.EventHandler(this.effacer);
		this.button_QUITTER.Clicked += new global::System.EventHandler(this.OnButtonQUITTERClicked);
	}
}
