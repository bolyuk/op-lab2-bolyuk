using System;
using Gtk;

namespace oplab1bolyuk
{
    public partial class GWindow : oplab1bolyuk.Swin
    {
        private ComboBox[,] matrix;
        private int[,] value;
        private bool turn = true;
        private bool finished = false;
        int _count = 0;

        public GWindow()
        {
            global::Stetic.Gui.Initialize(this);
          
            this.Name = "oplab1bolyuk.GWindow";
            this.WindowPosition = ((global::Gtk.WindowPosition)(4));

            this.vbox1 = new global::Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;

            this.table1 = new global::Gtk.Table(((uint)(5)), ((uint)(5)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));

            this.c1_1 = global::Gtk.ComboBox.NewText();
            this.c1_1.Name = "c1_1";
            this.table1.Add(this.c1_1);
            global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.c1_1]));
            w1.XOptions = ((global::Gtk.AttachOptions)(4));
            w1.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c1_2 = global::Gtk.ComboBox.NewText();
            this.c1_2.Name = "c1_2";
            this.table1.Add(this.c1_2);
            global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.c1_2]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.XOptions = ((global::Gtk.AttachOptions)(4));
            w2.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c1_3 = global::Gtk.ComboBox.NewText();
            this.c1_3.Name = "c1_3";
            this.table1.Add(this.c1_3);
            global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.c1_3]));
            w3.LeftAttach = ((uint)(2));
            w3.RightAttach = ((uint)(3));
            w3.XOptions = ((global::Gtk.AttachOptions)(4));
            w3.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c1_4 = global::Gtk.ComboBox.NewText();
            this.c1_4.Name = "c1_4";
            this.table1.Add(this.c1_4);
            global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.c1_4]));
            w4.LeftAttach = ((uint)(3));
            w4.RightAttach = ((uint)(4));
            w4.XOptions = ((global::Gtk.AttachOptions)(4));
            w4.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c1_5 = global::Gtk.ComboBox.NewText();
            this.c1_5.Name = "c1_5";
            this.table1.Add(this.c1_5);
            global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.c1_5]));
            w5.LeftAttach = ((uint)(4));
            w5.RightAttach = ((uint)(5));
            w5.XOptions = ((global::Gtk.AttachOptions)(4));
            w5.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c2_1 = global::Gtk.ComboBox.NewText();
            this.c2_1.Name = "c2_1";
            this.table1.Add(this.c2_1);
            global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.c2_1]));
            w6.TopAttach = ((uint)(1));
            w6.BottomAttach = ((uint)(2));
            w6.XOptions = ((global::Gtk.AttachOptions)(4));
            w6.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c2_2 = global::Gtk.ComboBox.NewText();
            this.c2_2.Name = "c2_2";
            this.table1.Add(this.c2_2);
            global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.c2_2]));
            w7.TopAttach = ((uint)(1));
            w7.BottomAttach = ((uint)(2));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.XOptions = ((global::Gtk.AttachOptions)(4));
            w7.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c2_3 = global::Gtk.ComboBox.NewText();
            this.c2_3.Name = "c2_3";
            this.table1.Add(this.c2_3);
            global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.c2_3]));
            w8.TopAttach = ((uint)(1));
            w8.BottomAttach = ((uint)(2));
            w8.LeftAttach = ((uint)(2));
            w8.RightAttach = ((uint)(3));
            w8.XOptions = ((global::Gtk.AttachOptions)(4));
            w8.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c2_4 = global::Gtk.ComboBox.NewText();
            this.c2_4.Name = "c2_4";
            this.table1.Add(this.c2_4);
            global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.c2_4]));
            w9.TopAttach = ((uint)(1));
            w9.BottomAttach = ((uint)(2));
            w9.LeftAttach = ((uint)(3));
            w9.RightAttach = ((uint)(4));
            w9.XOptions = ((global::Gtk.AttachOptions)(4));
            w9.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c2_5 = global::Gtk.ComboBox.NewText();
            this.c2_5.Name = "c2_5";
            this.table1.Add(this.c2_5);
            global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.c2_5]));
            w10.TopAttach = ((uint)(1));
            w10.BottomAttach = ((uint)(2));
            w10.LeftAttach = ((uint)(4));
            w10.RightAttach = ((uint)(5));
            w10.XOptions = ((global::Gtk.AttachOptions)(4));
            w10.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c3_1 = global::Gtk.ComboBox.NewText();
            this.c3_1.Name = "c3_1";
            this.table1.Add(this.c3_1);
            global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.c3_1]));
            w11.TopAttach = ((uint)(2));
            w11.BottomAttach = ((uint)(3));
            w11.XOptions = ((global::Gtk.AttachOptions)(4));
            w11.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c3_2 = global::Gtk.ComboBox.NewText();
            this.c3_2.Name = "c3_2";
            this.table1.Add(this.c3_2);
            global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.c3_2]));
            w12.TopAttach = ((uint)(2));
            w12.BottomAttach = ((uint)(3));
            w12.LeftAttach = ((uint)(1));
            w12.RightAttach = ((uint)(2));
            w12.XOptions = ((global::Gtk.AttachOptions)(4));
            w12.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c3_3 = global::Gtk.ComboBox.NewText();
            this.c3_3.Name = "c3_3";
            this.table1.Add(this.c3_3);
            global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.c3_3]));
            w13.TopAttach = ((uint)(2));
            w13.BottomAttach = ((uint)(3));
            w13.LeftAttach = ((uint)(2));
            w13.RightAttach = ((uint)(3));
            w13.XOptions = ((global::Gtk.AttachOptions)(4));
            w13.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c3_4 = global::Gtk.ComboBox.NewText();
            this.c3_4.Name = "c3_4";
            this.table1.Add(this.c3_4);
            global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.c3_4]));
            w14.TopAttach = ((uint)(2));
            w14.BottomAttach = ((uint)(3));
            w14.LeftAttach = ((uint)(3));
            w14.RightAttach = ((uint)(4));
            w14.XOptions = ((global::Gtk.AttachOptions)(4));
            w14.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c3_5 = global::Gtk.ComboBox.NewText();
            this.c3_5.Name = "c3_5";
            this.table1.Add(this.c3_5);
            global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.c3_5]));
            w15.TopAttach = ((uint)(2));
            w15.BottomAttach = ((uint)(3));
            w15.LeftAttach = ((uint)(4));
            w15.RightAttach = ((uint)(5));
            w15.XOptions = ((global::Gtk.AttachOptions)(4));
            w15.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c4_1 = global::Gtk.ComboBox.NewText();
            this.c4_1.Name = "c4_1";
            this.table1.Add(this.c4_1);
            global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.c4_1]));
            w16.TopAttach = ((uint)(3));
            w16.BottomAttach = ((uint)(4));
            w16.XOptions = ((global::Gtk.AttachOptions)(4));
            w16.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c4_2 = global::Gtk.ComboBox.NewText();
            this.c4_2.Name = "c4_2";
            this.table1.Add(this.c4_2);
            global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.c4_2]));
            w17.TopAttach = ((uint)(3));
            w17.BottomAttach = ((uint)(4));
            w17.LeftAttach = ((uint)(1));
            w17.RightAttach = ((uint)(2));
            w17.XOptions = ((global::Gtk.AttachOptions)(4));
            w17.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c4_3 = global::Gtk.ComboBox.NewText();
            this.c4_3.Name = "c4_3";
            this.table1.Add(this.c4_3);
            global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.c4_3]));
            w18.TopAttach = ((uint)(3));
            w18.BottomAttach = ((uint)(4));
            w18.LeftAttach = ((uint)(2));
            w18.RightAttach = ((uint)(3));
            w18.XOptions = ((global::Gtk.AttachOptions)(4));
            w18.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c4_4 = global::Gtk.ComboBox.NewText();
            this.c4_4.Name = "c4_4";
            this.table1.Add(this.c4_4);
            global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.c4_4]));
            w19.TopAttach = ((uint)(3));
            w19.BottomAttach = ((uint)(4));
            w19.LeftAttach = ((uint)(3));
            w19.RightAttach = ((uint)(4));
            w19.XOptions = ((global::Gtk.AttachOptions)(4));
            w19.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c4_5 = global::Gtk.ComboBox.NewText();
            this.c4_5.Name = "c4_5";
            this.table1.Add(this.c4_5);
            global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.c4_5]));
            w20.TopAttach = ((uint)(3));
            w20.BottomAttach = ((uint)(4));
            w20.LeftAttach = ((uint)(4));
            w20.RightAttach = ((uint)(5));
            w20.XOptions = ((global::Gtk.AttachOptions)(4));
            w20.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c5_1 = global::Gtk.ComboBox.NewText();
            this.c5_1.Name = "c5_1";
            this.table1.Add(this.c5_1);
            global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.c5_1]));
            w21.TopAttach = ((uint)(4));
            w21.BottomAttach = ((uint)(5));
            w21.XOptions = ((global::Gtk.AttachOptions)(4));
            w21.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c5_2 = global::Gtk.ComboBox.NewText();
            this.c5_2.Name = "c5_2";
            this.table1.Add(this.c5_2);
            global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.c5_2]));
            w22.TopAttach = ((uint)(4));
            w22.BottomAttach = ((uint)(5));
            w22.LeftAttach = ((uint)(1));
            w22.RightAttach = ((uint)(2));
            w22.XOptions = ((global::Gtk.AttachOptions)(4));
            w22.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c5_3 = global::Gtk.ComboBox.NewText();
            this.c5_3.Name = "c5_3";
            this.table1.Add(this.c5_3);
            global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.c5_3]));
            w23.TopAttach = ((uint)(4));
            w23.BottomAttach = ((uint)(5));
            w23.LeftAttach = ((uint)(2));
            w23.RightAttach = ((uint)(3));
            w23.XOptions = ((global::Gtk.AttachOptions)(4));
            w23.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c5_4 = global::Gtk.ComboBox.NewText();
            this.c5_4.Name = "c5_4";
            this.table1.Add(this.c5_4);
            global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.c5_4]));
            w24.TopAttach = ((uint)(4));
            w24.BottomAttach = ((uint)(5));
            w24.LeftAttach = ((uint)(3));
            w24.RightAttach = ((uint)(4));
            w24.XOptions = ((global::Gtk.AttachOptions)(4));
            w24.YOptions = ((global::Gtk.AttachOptions)(4));

            this.c5_5 = global::Gtk.ComboBox.NewText();
            this.c5_5.Name = "c5_5";
            this.table1.Add(this.c5_5);
            global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.c5_5]));
            w25.TopAttach = ((uint)(4));
            w25.BottomAttach = ((uint)(5));
            w25.LeftAttach = ((uint)(4));
            w25.RightAttach = ((uint)(5));
            w25.XOptions = ((global::Gtk.AttachOptions)(4));
            w25.YOptions = ((global::Gtk.AttachOptions)(4));
            this.vbox1.Add(this.table1);
            global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
            w26.Position = 0;
            w26.Expand = false;
            w26.Fill = false;

            this.label1 = new global::Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = "Інфо";
            this.vbox1.Add(this.label1);
            global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
            w27.Position = 1;
            w27.Expand = false;
            w27.Fill = false;

            this.button2 = new global::Gtk.Button();
            this.button2.CanFocus = true;
            this.button2.Name = "button2";
            this.button2.UseUnderline = true;
            this.button2.Label = global::Mono.Unix.Catalog.GetString("Меню");
            global::Gtk.Image w28 = new global::Gtk.Image();
            w28.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-undo", global::Gtk.IconSize.Menu);
            this.button2.Image = w28;
            this.vbox1.Add(this.button2);
            global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.button2]));
            w29.Position = 2;
            w29.Expand = false;
            w29.Fill = false;
            this.Add(this.vbox1);
            this.DefaultWidth = 184;
            this.DefaultHeight = 266;
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.Show();
            this.Show();

            title("Хрестики нулики");
            init();
            button2.Clicked += returns;
        }

        void logic(object sender, EventArgs e)
        {
            if (!finished)
            { 
            for (int i = 0; i < 5; i++)
                    for (int y = 0; y < 5; y++)
                    {
                        if (matrix[i, y].ActiveText != "-" && value[i, y] == 0)
                        {
                            if (check(matrix[i, y].ActiveText, turn))
                            {
                                turn = !turn;
                                value[i, y] = toInt(matrix[i, y].ActiveText);
                                label1.Text = "Файний хід! Наступним ходить " + toString(turn);
                                _count++;
                            }
                            else
                            {
                                label1.Text = "Не правильний хід! Зараз ходить " + toString(turn);
                                matrix[i, y].Active = 0;
                                return;
                            }
                        }
                        else if (toInt(matrix[i, y].ActiveText) != value[i, y] && toInt(matrix[i, y].ActiveText) != 0)
                        {
                            label1.Text = "Не можна змінювати минулі ходи!";
                            matrix[i, y].Active = value[i, y];
                            return;
                        }
                    }
                checkFinish("X");
                checkFinish("O");
                if(finished)
                    label1.Text = "Раунд завершено, переміг " + toString(!turn);
            }
            else
            {
                label1.Text = "Раунд завершено, переміг "+toString(!turn);
            }
            if (_count == 25 && !finished)
            {
                label1.Text = "Нічия, ходи скінчилися...";
                return;
            }
        }

        public void checkFinish(String buf)
        {
            String pattern = "";
            for (int i = 0; i < 4; i++) pattern += toInt(buf);
            String[] list = new string[25];
            for(int i=0; i<5; i++)
                for(int j=0; j<5;j++)
                {
                    list[i] += value[i, j];
                }
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    list[i+5] += value[j, i];
                }
            int c = 9;
            for(int i=0;i<2;i++)
            {
                for(int j=0; j<2;j++)
                {
                    for(int k=0; k+j < 5 && k+i<5;k++)
                        list[c]+= value[k+j, k+i];
                    c++;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 4; j > 2; j--)
                {
                    for (int k = 0; j-k >-1 && k+i<5; k++)
                        list[c] += value[k+i, j-k];
                    c++;
                }
            }

            for (int i=0; i<list.Length; i++)
                if(list[i] != null && list[i].Contains(pattern))
                {
                    finished = true;
                    return;
                }



        }

        public bool check(String text, bool turn)
         {
            if (text == "X" && turn) return true;
            if (text == "O" && !turn) return true;
            return false;
         }

        public int toInt(String t)
        {
            if (t == "X") return 1;
            if (t == "O") return 2;
            if (t == "-") return 0;
            return -1;
        }

        public String toString(Boolean b)
        {
            if (b) return "X"; else return "O";
        }




        void returns(object sender, EventArgs e)
        {
            menu();
        }

        private void init()
        {
            matrix = new ComboBox[,]{
            {c1_1, c1_2, c1_3, c1_4, c1_5},
            {c2_1, c2_2, c2_3, c2_4, c2_5},
            {c3_1, c3_2, c3_3, c3_4, c3_5},
            {c4_1, c4_2, c4_3, c4_4, c4_5},
            {c5_1, c5_2, c5_3, c5_4, c5_5}
           };
            value = new int[5, 5];
            for (int i = 0; i < 5; i++)
                for (int y = 0; y < 5; y++)
                {
                    matrix[i, y].AppendText("-");
                    matrix[i, y].AppendText("X");
                    matrix[i, y].AppendText("O");
                    matrix[i, y].Active = 0;
                    value[i, y] = 0;
                    matrix[i, y].Changed += logic;
                }
        }
    }
}
