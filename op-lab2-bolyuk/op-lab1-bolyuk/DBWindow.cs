using System;
using Gtk;

namespace oplab1bolyuk
{
    public partial class DBWindow : oplab1bolyuk.Swin
    {
        public DBWindow() 
        {
            global::Stetic.Gui.Initialize(this);

            this.Name = "oplab1bolyuk.DBWindow";
            this.Title = "DBWindow";
            this.WindowPosition = ((global::Gtk.WindowPosition)(4));

            this.vbox1 = new global::Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            this.vbox1.BorderWidth = ((uint)(3));

            this.label4 = new global::Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = "Номер Залікової книжки";
            this.vbox1.Add(this.label4);
            global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;

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

            this.label3 = new global::Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = "ПІП";
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

            this.label5 = new global::Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp ="Додаткова інформація";
            this.vbox1.Add(this.label5);
            global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label5]));
            w5.Position = 4;
            w5.Expand = false;
            w5.Fill = false;

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

            this.hbox2 = new global::Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;

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

            this.delbut = new global::Gtk.Button();
            this.delbut.CanFocus = true;
            this.delbut.Name = "delbut";
            this.delbut.UseUnderline = true;
            this.delbut.Label = "Видалити";
            global::Gtk.Image w9 = new global::Gtk.Image();
            w9.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-close", global::Gtk.IconSize.Menu);
            this.delbut.Image = w9;
            this.hbox2.Add(this.delbut);
            global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.delbut]));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;

            this.searchbut = new global::Gtk.Button();
            this.searchbut.CanFocus = true;
            this.searchbut.Name = "searchbut";
            this.searchbut.UseUnderline = true;
            this.searchbut.Label = "Пошук";
            global::Gtk.Image w11 = new global::Gtk.Image();
            w11.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-find", global::Gtk.IconSize.Menu);
            this.searchbut.Image = w11;
            this.hbox2.Add(this.searchbut);
            global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.searchbut]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;

            this.fixed1 = new global::Gtk.Fixed();
            this.fixed1.Name = "fixed1";
            this.fixed1.HasWindow = false;
            this.hbox2.Add(this.fixed1);
            global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.fixed1]));
            w13.Position = 3;

            this.menubut = new global::Gtk.Button();
            this.menubut.CanFocus = true;
            this.menubut.Name = "menubut";
            this.menubut.UseUnderline = true;
            this.menubut.Label ="Меню";
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

            this.label1 = new global::Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = "Інфо";
            this.vbox1.Add(this.label1);
            global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
            w17.Position = 7;
            w17.Expand = false;
            w17.Fill = false;
            this.Add(this.vbox1);

            this.DefaultWidth = 403;
            this.DefaultHeight = 260;
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.Show();
            this.Show();

            title("ДатаБаза");
            menubut.Clicked += (arg1, arg2) => menu();
            searchbut.Clicked += search;
            savebut.Clicked += add;
            delbut.Clicked += del;
            if (DB.getCount() != 0)
                label1.Text = $"Завантажено {DB.getCount()} студентів";
            else
                label1.Text = "ДатаБаза порожня";

        }

        void del(object sender, EventArgs e)
        {
            try
            {
                if (!DB.contain(number.Text))
            {
                label1.Text = "Ви ввели неправильний номер заліковки!";
                return;
            }
                DB.del(number.Text);
                label1.Text = "Успіх!";
            }
            catch
            {
                label1.Text = "Помилка :\\";
            }
        }


        void search(object sender, EventArgs e)
        {
            if(number.Text == "")
            {
                label1.Text = "Для пошуку потрібно ввести Номер залікової книжки";
                return;
            }

            if(!DB.contain(number.Text))
            {
                label1.Text = "Ви ввели неправильний номер заліковки!";
                return;
            }

            String[] r = DB.search(number.Text);
            name.Text = r[1];
            info.Text = r[2];
            label1.Text = "Успіх!";
        }

        void add(object sender, EventArgs e)
        {
            try {
                if (number.Text.Contains("~") || name.Text.Contains("~") || info.Text.Contains("~"))
                {
                    label1.Text = "Не можна використовувати символ \"~\"!";
                    return;
                }
            if (number.Text == "")
            {
                label1.Text = "Номер залікової книжки не може бути порожнім!";
                return;
            }
            if (name.Text == "")
            {
                label1.Text = "ПІП не може бути порожнім!";
                return;
            }
                if (!DB.contain(number.Text))
                {
                    DB.add(number.Text, name.Text, info.Text);
                    label1.Text = "Успіх!";
                }
                else
                {
                    DB.edit(number.Text, name.Text, info.Text);
                    label1.Text = "Данний студент зареєстрований, данні оновлені!";
                }
            } catch(Exception err)
             {
                label1.Text = "Помилка :\\";
                System.Console.Write(err);
            }

        }

    }
}
