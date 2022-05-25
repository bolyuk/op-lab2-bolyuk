﻿using System;
using System.Collections.Generic;
using Gtk;
using oplab1bolyuk;

namespace oplab1bolyuk
{
    public partial class СWindow : oplab1bolyuk.Swin
    {
        Button[] nums;

        List<String> buffer = new List<String>();
        public СWindow()
        {
            global::Stetic.Gui.Initialize(this);
            // Widget oplab1bolyuk.СWindow
            this.Name = "oplab1bolyuk.СWindow";
            this.Title = global::Mono.Unix.Catalog.GetString("Калькулятор");
            this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-harddisk", global::Gtk.IconSize.Menu);
            this.WindowPosition = ((global::Gtk.WindowPosition)(1));
            this.Resizable = false;
            this.DefaultWidth = 500;
            this.DefaultHeight = 500;
            this.Gravity = ((global::Gdk.Gravity)(5));
            // Container child oplab1bolyuk.СWindow.Gtk.Container+ContainerChild
            this.vbox6 = new global::Gtk.VBox();
            this.vbox6.Name = "vbox6";
            this.vbox6.Spacing = 6;
            // Container child vbox6.Gtk.Box+BoxChild
            this.hbox1 = new global::Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.menubut = new global::Gtk.Button();
            this.menubut.CanFocus = true;
            this.menubut.Name = "menubut";
            this.menubut.Label = global::Mono.Unix.Catalog.GetString("Меню");
            global::Gtk.Image w1 = new global::Gtk.Image();
            w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-undo", global::Gtk.IconSize.Menu);
            this.menubut.Image = w1;
            this.hbox1.Add(this.menubut);
            global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.menubut]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.resultbut = new global::Gtk.Button();
            this.resultbut.CanFocus = true;
            this.resultbut.Name = "resultbut";
            this.resultbut.UseUnderline = true;
            this.resultbut.Label = global::Mono.Unix.Catalog.GetString("Результат");
            this.hbox1.Add(this.resultbut);
            global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.resultbut]));
            w3.Position = 1;
            this.vbox6.Add(this.hbox1);
            global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.info = new global::Gtk.Label();
            this.info.Name = "info";
            this.info.Selectable = true;
            this.vbox6.Add(this.info);
            global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.info]));
            w5.Position = 1;
            w5.Padding = ((uint)(1));
            // Container child vbox6.Gtk.Box+BoxChild
            this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(4)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.but1 = new global::Gtk.Button();
            this.but1.CanFocus = true;
            this.but1.Name = "but1";
            this.but1.UseUnderline = true;
            this.but1.Label = global::Mono.Unix.Catalog.GetString("1");
            this.table1.Add(this.but1);
            global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.but1]));
            w6.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.but2 = new global::Gtk.Button();
            this.but2.CanFocus = true;
            this.but2.Name = "but2";
            this.but2.UseUnderline = true;
            this.but2.Label = global::Mono.Unix.Catalog.GetString("2");
            this.table1.Add(this.but2);
            global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.but2]));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.but3 = new global::Gtk.Button();
            this.but3.CanFocus = true;
            this.but3.Name = "but3";
            this.but3.UseUnderline = true;
            this.but3.Label = global::Mono.Unix.Catalog.GetString("3");
            this.table1.Add(this.but3);
            global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.but3]));
            w8.LeftAttach = ((uint)(2));
            w8.RightAttach = ((uint)(3));
            w8.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.but4 = new global::Gtk.Button();
            this.but4.CanFocus = true;
            this.but4.Name = "but4";
            this.but4.UseUnderline = true;
            this.but4.Label = global::Mono.Unix.Catalog.GetString("4");
            this.table1.Add(this.but4);
            global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.but4]));
            w9.TopAttach = ((uint)(1));
            w9.BottomAttach = ((uint)(2));
            w9.XOptions = ((global::Gtk.AttachOptions)(4));
            w9.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.but5 = new global::Gtk.Button();
            this.but5.CanFocus = true;
            this.but5.Name = "but5";
            this.but5.UseUnderline = true;
            this.but5.Label = global::Mono.Unix.Catalog.GetString("5");
            this.table1.Add(this.but5);
            global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.but5]));
            w10.TopAttach = ((uint)(1));
            w10.BottomAttach = ((uint)(2));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            w10.XOptions = ((global::Gtk.AttachOptions)(4));
            w10.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.but6 = new global::Gtk.Button();
            this.but6.CanFocus = true;
            this.but6.Name = "but6";
            this.but6.UseUnderline = true;
            this.but6.Label = global::Mono.Unix.Catalog.GetString("6");
            this.table1.Add(this.but6);
            global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.but6]));
            w11.TopAttach = ((uint)(1));
            w11.BottomAttach = ((uint)(2));
            w11.LeftAttach = ((uint)(2));
            w11.RightAttach = ((uint)(3));
            w11.XOptions = ((global::Gtk.AttachOptions)(4));
            w11.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.but7 = new global::Gtk.Button();
            this.but7.CanFocus = true;
            this.but7.Name = "but7";
            this.but7.UseUnderline = true;
            this.but7.Label = global::Mono.Unix.Catalog.GetString("7");
            this.table1.Add(this.but7);
            global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.but7]));
            w12.TopAttach = ((uint)(2));
            w12.BottomAttach = ((uint)(3));
            w12.XOptions = ((global::Gtk.AttachOptions)(4));
            w12.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.but8 = new global::Gtk.Button();
            this.but8.CanFocus = true;
            this.but8.Name = "but8";
            this.but8.UseUnderline = true;
            this.but8.Label = global::Mono.Unix.Catalog.GetString("8");
            this.table1.Add(this.but8);
            global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.but8]));
            w13.TopAttach = ((uint)(2));
            w13.BottomAttach = ((uint)(3));
            w13.LeftAttach = ((uint)(1));
            w13.RightAttach = ((uint)(2));
            w13.XOptions = ((global::Gtk.AttachOptions)(4));
            w13.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.but9 = new global::Gtk.Button();
            this.but9.CanFocus = true;
            this.but9.Name = "but9";
            this.but9.UseUnderline = true;
            this.but9.Label = global::Mono.Unix.Catalog.GetString("9");
            this.table1.Add(this.but9);
            global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.but9]));
            w14.TopAttach = ((uint)(2));
            w14.BottomAttach = ((uint)(3));
            w14.LeftAttach = ((uint)(2));
            w14.RightAttach = ((uint)(3));
            w14.XOptions = ((global::Gtk.AttachOptions)(4));
            w14.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.butnul = new global::Gtk.Button();
            this.butnul.CanFocus = true;
            this.butnul.Name = "butnul";
            this.butnul.UseUnderline = true;
            this.butnul.Label = global::Mono.Unix.Catalog.GetString("0");
            this.table1.Add(this.butnul);
            global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.butnul]));
            w15.TopAttach = ((uint)(2));
            w15.BottomAttach = ((uint)(3));
            w15.LeftAttach = ((uint)(3));
            w15.RightAttach = ((uint)(4));
            w15.XOptions = ((global::Gtk.AttachOptions)(4));
            w15.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.clearbut = new global::Gtk.Button();
            this.clearbut.CanFocus = true;
            this.clearbut.Name = "clearbut";
            this.clearbut.UseUnderline = true;
            this.clearbut.Label = global::Mono.Unix.Catalog.GetString("C");
            this.table1.Add(this.clearbut);
            global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.clearbut]));
            w16.TopAttach = ((uint)(1));
            w16.BottomAttach = ((uint)(2));
            w16.LeftAttach = ((uint)(3));
            w16.RightAttach = ((uint)(4));
            w16.XOptions = ((global::Gtk.AttachOptions)(4));
            w16.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.dotbut = new global::Gtk.Button();
            this.dotbut.CanFocus = true;
            this.dotbut.Name = "dotbut";
            this.dotbut.UseUnderline = true;
            this.dotbut.Label = global::Mono.Unix.Catalog.GetString(",");
            this.table1.Add(this.dotbut);
            global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.dotbut]));
            w17.LeftAttach = ((uint)(3));
            w17.RightAttach = ((uint)(4));
            w17.XOptions = ((global::Gtk.AttachOptions)(4));
            w17.YOptions = ((global::Gtk.AttachOptions)(4));
            this.vbox6.Add(this.table1);
            global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.table1]));
            w18.Position = 2;
            w18.Expand = false;
            w18.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.hbox2 = new global::Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.divisbut = new global::Gtk.Button();
            this.divisbut.CanFocus = true;
            this.divisbut.Name = "divisbut";
            this.divisbut.UseUnderline = true;
            this.divisbut.Label = global::Mono.Unix.Catalog.GetString("/");
            this.hbox2.Add(this.divisbut);
            global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.divisbut]));
            w19.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.multbut = new global::Gtk.Button();
            this.multbut.CanFocus = true;
            this.multbut.Name = "multbut";
            this.multbut.UseUnderline = true;
            this.multbut.Label = global::Mono.Unix.Catalog.GetString("*");
            this.hbox2.Add(this.multbut);
            global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.multbut]));
            w20.Position = 1;
            // Container child hbox2.Gtk.Box+BoxChild
            this.minusbut = new global::Gtk.Button();
            this.minusbut.CanFocus = true;
            this.minusbut.Name = "minusbut";
            this.minusbut.UseUnderline = true;
            this.minusbut.Label = global::Mono.Unix.Catalog.GetString("-");
            this.hbox2.Add(this.minusbut);
            global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.minusbut]));
            w21.Position = 2;
            // Container child hbox2.Gtk.Box+BoxChild
            this.plusbut = new global::Gtk.Button();
            this.plusbut.CanFocus = true;
            this.plusbut.Name = "plusbut";
            this.plusbut.UseUnderline = true;
            this.plusbut.Label = global::Mono.Unix.Catalog.GetString("+");
            this.hbox2.Add(this.plusbut);
            global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.plusbut]));
            w22.Position = 3;
            this.vbox6.Add(this.hbox2);
            global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox2]));
            w23.Position = 3;
            // Container child vbox6.Gtk.Box+BoxChild
            this.label5 = new global::Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Калькулятор ігнорує пріоритетність дій!");
            this.vbox6.Add(this.label5);
            global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label5]));
            w24.Position = 4;
            w24.Expand = false;
            w24.Fill = false;
            this.Add(this.vbox6);
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.Show();
            title("Калькулятор");
            init();
        }

        private void init() 
        {
            menubut.Clicked += (sender, e) => menu();

            resultbut.Clicked += (sender, e) => calculation();
            clearbut.Clicked += (sender, e) => { bufchange('e'); };
            nums = new Button[] {butnul, but1, but2, but3, but4, but5, but6, but7, but8, but9,
                 dotbut, divisbut, multbut, minusbut, plusbut};
            for(int i=0; i<nums.Length; i++)
                nums[i].Clicked +=  (sender, e) => { 
                bufchange(Char.Parse(((Button)sender).Label));
                    info.Text = getBuffer();
                };
        }

        public void calculation() 
        {
            try {
                Double result = Convert.ToDouble(buffer[0]);
                for (int i = 1; i < buffer.Count-1; i+=2)
                        switch(buffer[i])
                        {
                            case "-":
                            result-= Convert.ToDouble(buffer[i+1]);
                            break;
                            case "+":
                            result += Convert.ToDouble(buffer[i + 1]);
                            break;
                            case "/":
                            result /= Convert.ToDouble(buffer[i + 1]);
                            break;
                            case "*":
                            result *= Convert.ToDouble(buffer[i + 1]);
                            break;
                        }
                buffer.Clear();
                label5.Text = "Успіх!";
                buffer.Add(result.ToString());
                info.Text = getBuffer();
            }
            catch(Exception e)
            {
                label5.Text = "Помилка!";
                System.Console.Write(e);
            }

        }


        public void bufchange(Char t)
        {
            if (t == 'e')
            {
                buffer = new List<String>();
                info.Text = getBuffer();
                return;
            }
            String last = "";
            if (buffer.Count != 0)
                last = buffer[buffer.Count - 1];
            else if (Char.IsDigit(t))
            {
                buffer.Add(t.ToString());
                info.Text = getBuffer();
                return;
            }
            else return;


            if ((last.EndsWith(",") || isOperand(last)) && (isOperand(t.ToString()) || t == ',')) return;
            if (t == '.' && last.Contains(",")) return;
            if ((Char.IsDigit(getLast(last)) || getLast(last) == ',') && (Char.IsDigit(t) || t == ','))
            {
                buffer.RemoveAt(buffer.Count - 1);
                buffer.Add(last + t);
            }
            else
                buffer.Add(t.ToString());
                
            info.Text = getBuffer();
        }

        public char getLast(String t)
        {
            if (t.Length == 0) return Char.Parse(t);
            return Char.Parse(t.Substring(t.Length - 1));
        }


        public bool isOperand(String t)
        { return t == "/" || t == "*" || t == "-" || t == "+"; }

        public String getBuffer()
        {
            String r = "";
            for (int i = 0; i < buffer.Count; i++)
                r += buffer[i] + " ";
            return r;
        }


    }
}