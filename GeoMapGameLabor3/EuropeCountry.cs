using GeoMapGameLabor3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeoMapGameLabor3
{
    public partial class EuropeCountry : Form
    {

        PictureBox pb;
        System.Windows.Forms.Label l1, l_Albania, l_Andorra, l_Armenia, l_Austria, l_Azerbaijan, l_Belarus, l_Belgium, l_Bosnia_and_Herzegovina, l_Bulgaria, l_Croatia, l_Cyprus, l_Czech_Republic, l_Denmark, l_Estonia, l_Finland, l_France, l_Georgia, l_Germany, l_Greece, l_Hungary, l_Iceland, l_Ireland, l_Italy, l_Kazakhstan, l_Kosovo, l_Latvia, l_Liechtenstein, l_Lithuania, l_Luxembourg, l_Malta, l_Moldova, l_Monaco, l_Montenegro, l_Netherlands, l_North_Macedonia, l_Norway, l_Poland, l_Portugal, l_Romania, l_Russia, l_San_Marino, l_Serbia, l_Slovakia, l_Slovenia, l_Spain, l_Sweden, l_Switzerland, l_Turkey, l_Ukraine, l_United_Kingdom;
        System.Windows.Forms.Button btn;
        Map EuropaCountry = new Map("../../../lists/EuropeCountries.txt");
        System.Windows.Forms.TextBox textBox1;
        int X_l1 = 0, Y_l1 = 0;
        bool Label1Bool = false;
        int X_label = 0, Y_label = 0;
        string countryNamel1;
        System.Windows.Forms.Label final_label, countryNameLabel, result_label, final1_label, final2_label;
        List<System.Windows.Forms.Label> list_l_country = new List<System.Windows.Forms.Label>();
        string test;
        int k;

        public EuropeCountry()
        {
            this.Height = 800;
            this.Width = 1000;
            this.Text = "Euroopi riigid nimega";
            pb = new PictureBox();

            pb.Location = new Point(10, 50);

            pb.Image = new Bitmap("../../../maps/europe_map.png");
            pb.Size = new Size(960, 700);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.BorderStyle = BorderStyle.Fixed3D;
            pb.MouseDown += Pb_MouseDown;
            pb.MouseMove += Pb_MouseMove;
            this.Controls.Add(pb);

            EuropaCountry.ListAndMap();

            



            l1 = new System.Windows.Forms.Label();
            l1.Font = new Font("Arial", 8, FontStyle.Bold);
            l1.Size = new Size(10, 10);
            l1.Location = new Point(400, 10);
            l1.BackColor = Color.Orange;
            l1.BorderStyle = BorderStyle.Fixed3D;
            l1.MouseDown += L1_MouseDown;
            l1.MouseMove += L1_MouseMove;
            pb.Controls.Add(l1);

            countryNameLabel = new System.Windows.Forms.Label();
            countryNameLabel.Font = new Font("Arial", 24, FontStyle.Bold);
            countryNameLabel.Size = new Size(200, 40);
            countryNamel1 = EuropaCountry.CountryName();
            countryNameLabel.Text = countryNamel1;
            countryNameLabel.Location = new Point(300, 10);
            countryNameLabel.BackColor = Color.LightGray;
            countryNameLabel.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(countryNameLabel);

            btn = new System.Windows.Forms.Button();
            btn.Location = new Point(1, 1);
            btn.Size = new Size(50, 30);
            btn.Text = "Next";
            btn.Click += Btn_Click;
            this.Controls.Add(btn);

            final_label = new System.Windows.Forms.Label();
            final_label.Font = new Font("Arial", 7, FontStyle.Bold);
            final_label.Size = new Size(800, 900);
            final_label.Location = new Point(0, 100);
            final_label.Text = "Final";
            final_label.Visible = false;
            this.Controls.Add(final_label);

            final1_label = new System.Windows.Forms.Label();
            final1_label.Font = new Font("Arial", 7, FontStyle.Bold);
            final1_label.Size = new Size(100, 30);
            final1_label.Location = new Point(800, 10);
            final1_label.Text = "";
            this.Controls.Add(final1_label);

            final2_label = new System.Windows.Forms.Label();
            final2_label.Font = new Font("Arial", 7, FontStyle.Bold);
            final2_label.Size = new Size(100, 30);
            final2_label.Location = new Point(700, 10);
            final2_label.Text = "";
            this.Controls.Add(final2_label);

            result_label = new System.Windows.Forms.Label();
            result_label.Font = new Font("Arial", 12, FontStyle.Bold);
            result_label.Size = new Size(100, 30);
            result_label.Text = " ";
            result_label.Location = new Point(600, 10);
            result_label.BackColor = Color.LightGray;
            result_label.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(result_label);



            l_Albania = CreateCountryLabel("Albania", 535, 470);
            pb.Controls.Add(l_Albania);

            l_Andorra = CreateCountryLabel("Andorra", 330, 460);
            pb.Controls.Add(l_Andorra);

            l_Armenia = CreateCountryLabel("Armenia", 870, 475);
            pb.Controls.Add(l_Armenia);

            l_Austria = CreateCountryLabel("Austria", 460, 355);
            pb.Controls.Add(l_Austria);

            l_Azerbaijan = CreateCountryLabel("Azerbaijan", 910, 475);
            pb.Controls.Add(l_Azerbaijan);

            l_Belarus = CreateCountryLabel("Belarus", 620, 250);
            pb.Controls.Add(l_Belarus);

            l_Belgium = CreateCountryLabel("Belgium", 340, 310);
            pb.Controls.Add(l_Belgium);

            l_Bosnia_and_Herzegovina = CreateCountryLabel("Bosnia and Herzegovina", 510, 415);
            pb.Controls.Add(l_Bosnia_and_Herzegovina);

            l_Bulgaria = CreateCountryLabel("Bulgaria", 590, 445);
            pb.Controls.Add(l_Bulgaria);

            l_Croatia = CreateCountryLabel("Croatia", 470, 410);
            pb.Controls.Add(l_Croatia);

            l_Cyprus = CreateCountryLabel("Cyprus", 720, 560);
            pb.Controls.Add(l_Cyprus);

            l_Czech_Republic = CreateCountryLabel("Czech Republic", 460, 320);
            pb.Controls.Add(l_Czech_Republic);

            l_Denmark = CreateCountryLabel("Denmark", 400, 220);
            pb.Controls.Add(l_Denmark);

            l_Estonia = CreateCountryLabel("Estonia", 585, 180);
            pb.Controls.Add(l_Estonia);

            l_Finland = CreateCountryLabel("Finland", 585, 130);
            pb.Controls.Add(l_Finland);

            l_France = CreateCountryLabel("France", 300, 340);
            pb.Controls.Add(l_France);

            l_Georgia = CreateCountryLabel("Georgia", 855, 450);
            pb.Controls.Add(l_Georgia);

            l_Germany = CreateCountryLabel("Germany", 400, 310);
            pb.Controls.Add(l_Germany);

            l_Greece = CreateCountryLabel("Greece", 560, 500);
            pb.Controls.Add(l_Greece);

            l_Hungary = CreateCountryLabel("Hungary", 510, 370);
            pb.Controls.Add(l_Hungary);

            l_Iceland = CreateCountryLabel("Iceland", 90, 100);
            pb.Controls.Add(l_Iceland);

            l_Ireland = CreateCountryLabel("Ireland", 180, 280);
            pb.Controls.Add(l_Ireland);

            l_Italy = CreateCountryLabel("Italy", 400, 400);
            pb.Controls.Add(l_Italy);

            l_Kazakhstan = CreateCountryLabel("Kazakhstan", 910, 320);
            pb.Controls.Add(l_Kazakhstan);

            l_Kosovo = CreateCountryLabel("Kosovo", 545, 530);
            pb.Controls.Add(l_Kosovo);

            l_Latvia = CreateCountryLabel("Latvia", 585, 210);
            pb.Controls.Add(l_Latvia);

            l_Liechtenstein = CreateCountryLabel("Liechtenstein", 370, 450);
            pb.Controls.Add(l_Liechtenstein);

            l_Lithuania = CreateCountryLabel("Lithuania", 575, 240);
            pb.Controls.Add(l_Lithuania);

            l_Luxembourg = CreateCountryLabel("Luxembourg", 335, 250);
            pb.Controls.Add(l_Luxembourg);

            l_Malta = CreateCountryLabel("Malta", 455, 560);
            pb.Controls.Add(l_Malta);

            l_Moldova = CreateCountryLabel("Moldova", 640, 370);
            pb.Controls.Add(l_Moldova);

            l_Monaco = CreateCountryLabel("Monaco", 350, 445);
            pb.Controls.Add(l_Monaco);

            l_Montenegro = CreateCountryLabel("Montenegro", 510, 460);
            pb.Controls.Add(l_Montenegro);

            l_Netherlands = CreateCountryLabel("Netherlands", 350, 280);
            pb.Controls.Add(l_Netherlands);

            l_North_Macedonia = CreateCountryLabel("North Macedonia", 560, 455);
            pb.Controls.Add(l_North_Macedonia);

            l_Norway = CreateCountryLabel("Norway", 400, 130);
            pb.Controls.Add(l_Norway);

            l_Poland = CreateCountryLabel("Poland", 510, 280);
            pb.Controls.Add(l_Poland);

            l_Portugal = CreateCountryLabel("Portugal", 160, 470);
            pb.Controls.Add(l_Portugal);

            l_Romania = CreateCountryLabel("Romania", 600, 380);
            pb.Controls.Add(l_Romania);

            l_Russia = CreateCountryLabel("Russia", 700, 180);
            pb.Controls.Add(l_Russia);

            l_San_Marino = CreateCountryLabel("San Marino", 470, 430);
            pb.Controls.Add(l_San_Marino);

            l_Serbia = CreateCountryLabel("Serbia", 540, 415);
            pb.Controls.Add(l_Serbia);

            l_Slovakia = CreateCountryLabel("Slovakia", 520, 340);
            pb.Controls.Add(l_Slovakia);

            l_Slovenia = CreateCountryLabel("Slovenia", 460, 385);
            pb.Controls.Add(l_Slovenia);

            l_Spain = CreateCountryLabel("Spain", 230, 470);
            pb.Controls.Add(l_Spain);

            l_Sweden = CreateCountryLabel("Sweden", 460, 140);
            pb.Controls.Add(l_Sweden);

            l_Switzerland = CreateCountryLabel("Switzerland", 380, 370);
            pb.Controls.Add(l_Switzerland);

            l_Turkey = CreateCountryLabel("Turkey", 730, 490);
            pb.Controls.Add(l_Turkey);

            l_Ukraine = CreateCountryLabel("Ukraine", 700, 350);
            pb.Controls.Add(l_Ukraine);

            l_United_Kingdom = CreateCountryLabel("United Kingdom", 260, 270);
            pb.Controls.Add(l_United_Kingdom);
            
        }
        public void AddToListLabels()
        {
            list_l_country.AddRange(new System.Windows.Forms.Label[] { l_Albania, l_Andorra, l_Armenia, l_Austria, l_Azerbaijan, l_Belarus, l_Belgium, l_Bosnia_and_Herzegovina, l_Bulgaria, l_Croatia, l_Cyprus, l_Czech_Republic, l_Denmark, l_Estonia, l_Finland, l_France, l_Georgia, l_Germany, l_Greece, l_Hungary, l_Iceland, l_Ireland, l_Italy, l_Kazakhstan, l_Kosovo, l_Latvia, l_Liechtenstein, l_Lithuania, l_Luxembourg, l_Malta, l_Moldova, l_Monaco, l_Montenegro, l_Netherlands, l_North_Macedonia, l_Norway, l_Poland, l_Portugal, l_Romania, l_Russia, l_San_Marino, l_Serbia, l_Slovakia, l_Slovenia, l_Spain, l_Sweden, l_Switzerland, l_Turkey, l_Ukraine, l_United_Kingdom });
        }
        private System.Windows.Forms.Label CreateCountryLabel(string countryName, int x, int y)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Size = new Size(15, 15);
            label.Location = new Point(x, y);
            label.Text = " ";
            label.BackColor = Color.Gray;
            label.BorderStyle = BorderStyle.Fixed3D;

            return label;
        }

        private void Btn_Click(object? sender, EventArgs e) 
        {
            k++;
            final2_label.Text = k.ToString();
            AddToListLabels();
            for (int x = 0; x < list_l_country.Count; x++)//Здесь идёт проверка места, с ней всё нормально вроде
            {

                if ((l1.Location.X < list_l_country[x].Location.X + list_l_country[x].Width) && (l1.Location.X > list_l_country[x].Location.X))
                {
                    if ((l1.Location.Y < list_l_country[x].Location.Y + list_l_country[x].Height) && (l1.Location.Y > list_l_country[x].Location.Y))
                    {

                        //for (int k = 0; countryNamel1 != EuropaCountry.ListCountryIndex(k); k++) 
                        //    //здесь я уже добавил этот цикл от отчаяния, посчитал что возможно поможет что-то сделать.
                        //    //Проблема в том что в ListCountryIndex i равняется нулл почему-то. И не работают нормально ни числа (x и k) ни индексы. Я уже запутался здесь в логике. Возможно полностью здесь всё перепишу с 341 по 370 строку
                        //    //Первый цикл у нас достаёт индекс лейбла и сравнивает с кордами. Второй должен как бы проверять название. Когда ставил в 354 строке вместо к, х. То получалось что например при первом нажатии
                        //    //брало не албанию как надо, а Андорру. При втором нажатии уже через одну страну брало, и так далее
                        //{
                            final1_label.Text = EuropaCountry.ListCountryIndex(x);
                            
                            if (countryNamel1 == EuropaCountry.ListCountryIndex(x))
                            {

                                result_label.Text = "correct";
                                break;
                            }
                            else
                            {
                                result_label.Text = "false";
                            }
                        //}
                    }
                    else
                    {
                        result_label.Text = "false";
                    }

                }

            }
            if (countryNamel1 == "")
            {
                final_label.Visible = true;
                pb.Visible = false;

            }
            else
            {
                countryNamel1 = EuropaCountry.CountryName();
                countryNameLabel.Text = countryNamel1;
            }

            l1.Location = new Point(400, 10);


        }

        private void Pb_MouseDown(object sender, MouseEventArgs e)
        {
            X_label = e.X;
            Y_label = e.Y;
        }

        private void Pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                l1.Left += e.X - X_label;
                l1.Top += e.Y - Y_label;
            }
        }

        private void L1_MouseDown(object sender, MouseEventArgs e)
        {
            X_l1 = e.X;
            Y_l1 = e.Y;

        }

        private void L1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                l1.Left += e.X - X_l1;
                l1.Top += e.Y - Y_l1;
            }
        }


    }
}


