
// This file has been generated by the GUI designer. Do not modify.
namespace oplab1bolyuk
{
	public partial class DBWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label4;

		private global::Gtk.Entry number;

		private global::Gtk.Label label3;

		private global::Gtk.Entry name;

		private global::Gtk.Label label5;

		private global::Gtk.Entry info;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button savebut;

		private global::Gtk.Button delbut;

		private global::Gtk.Button searchbut;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button menubut;

		private global::Gtk.Label label1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget oplab1bolyuk.DBWindow
			this.Name = "oplab1bolyuk.DBWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("DBWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child oplab1bolyuk.DBWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(3));
			// Container child vbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Номер Залікової книжки");
			this.vbox1.Add(this.label4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.number = new global::Gtk.Entry();
			this.number.CanFocus = true;
			this.number.Name = "number";
			this.number.IsEditable = true;
			this.number.InvisibleChar = '•';
			this.vbox1.Add(this.number);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.number]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("ПІП");
			this.vbox1.Add(this.label3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label3]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.name = new global::Gtk.Entry();
			this.name.CanFocus = true;
			this.name.Name = "name";
			this.name.IsEditable = true;
			this.name.InvisibleChar = '•';
			this.vbox1.Add(this.name);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.name]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Додаткова інформація");
			this.vbox1.Add(this.label5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label5]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.info = new global::Gtk.Entry();
			this.info.CanFocus = true;
			this.info.Name = "info";
			this.info.IsEditable = true;
			this.info.InvisibleChar = '•';
			this.vbox1.Add(this.info);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.info]));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.savebut = new global::Gtk.Button();
			this.savebut.CanFocus = true;
			this.savebut.Name = "savebut";
			this.savebut.UseUnderline = true;
			this.savebut.Label = global::Mono.Unix.Catalog.GetString("Додати");
			global::Gtk.Image w7 = new global::Gtk.Image();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.savebut.Image = w7;
			this.hbox2.Add(this.savebut);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.savebut]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.delbut = new global::Gtk.Button();
			this.delbut.CanFocus = true;
			this.delbut.Name = "delbut";
			this.delbut.UseUnderline = true;
			this.delbut.Label = global::Mono.Unix.Catalog.GetString("Видалити");
			global::Gtk.Image w9 = new global::Gtk.Image();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-close", global::Gtk.IconSize.Menu);
			this.delbut.Image = w9;
			this.hbox2.Add(this.delbut);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.delbut]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.searchbut = new global::Gtk.Button();
			this.searchbut.CanFocus = true;
			this.searchbut.Name = "searchbut";
			this.searchbut.UseUnderline = true;
			this.searchbut.Label = global::Mono.Unix.Catalog.GetString("Пошук");
			global::Gtk.Image w11 = new global::Gtk.Image();
			w11.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-find", global::Gtk.IconSize.Menu);
			this.searchbut.Image = w11;
			this.hbox2.Add(this.searchbut);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.searchbut]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox2.Add(this.fixed1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.fixed1]));
			w13.Position = 3;
			// Container child hbox2.Gtk.Box+BoxChild
			this.menubut = new global::Gtk.Button();
			this.menubut.CanFocus = true;
			this.menubut.Name = "menubut";
			this.menubut.UseUnderline = true;
			this.menubut.Label = global::Mono.Unix.Catalog.GetString("Меню");
			global::Gtk.Image w14 = new global::Gtk.Image();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-undo", global::Gtk.IconSize.Menu);
			this.menubut.Image = w14;
			this.hbox2.Add(this.menubut);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.menubut]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w16.Position = 6;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Інфо");
			this.vbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w17.Position = 7;
			w17.Expand = false;
			w17.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 403;
			this.DefaultHeight = 260;
			this.Show();
		}
	}
}
