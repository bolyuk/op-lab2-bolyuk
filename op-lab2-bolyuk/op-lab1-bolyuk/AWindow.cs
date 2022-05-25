using System;
using static Gtk.Box;

namespace oplab1bolyuk
{
    public partial class AWindow : oplab1bolyuk.Swin
    {
        public AWindow() 
        {
            global::Stetic.Gui.Initialize(this);
           
            this.Name = "oplab1bolyuk.AWindow";
            this.WindowPosition = ((global::Gtk.WindowPosition)(4));

            this.vbox7 = new global::Gtk.VBox();
            this.vbox7.Name = "vbox7";
            this.vbox7.Spacing = 6;

            this.label6 = new global::Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = "Болюк Д.В КП-12        2022 рік";
            this.vbox7.Add(this.label6);
            global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label6]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;

            this.label7 = new global::Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = "https://github.com/bolyuk/op-lab2-bolyuk";
            this.label7.Selectable = true;
            this.vbox7.Add(this.label7);
            global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label7]));
            w2.Position = 1;

            button15 = new global::Gtk.Button();
            button15.CanFocus = true;
            button15.Name = "button15";
            button15.UseUnderline = true;
            button15.Label = "Меню";

            Gtk.Image w3 = new Gtk.Image();
            w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-undo", global::Gtk.IconSize.Menu);
            this.button15.Image = w3;
            this.vbox7.Add(this.button15);

            BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.button15]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;

            this.Add(this.vbox7); 
            this.Child.ShowAll();
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();

            title("Про мене");
            button15.Clicked += (sender, e) => menu();
        }
    }
}
