using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Gym_Buddy_App
{
    public partial class Dodaj_grupen_trening : Form
    {
        public Dodaj_grupen_trening()
        {
            InitializeComponent();
        }
        Button members = new Button();
        bool buttonPressed;
        Button newMbr = new Button();
        Button izmeniMbr = new Button();
        Button allMbr = new Button();
        Button vrab = new Button();
        bool buttonPressed1;
        Button newVrab = new Button();
        Button izmeniVrab = new Button();
        Button allVrab = new Button();
        Button oprema = new Button();
        bool buttonPressed2;
        Button celaop = new Button();
        Button novaop = new Button();
        Button izbrisiop = new Button();
        Button proizvodi = new Button();
        bool buttonPressed5;
        Button clenskiKarti = new Button();
        Button lcTrenizni = new Button();
        Button grTrenizi = new Button();
        Button suplementi = new Button();
        Button izlez = new Button();
        bool buttonPressed4;
        Button logout = new Button();
        Button exit = new Button();
        Button bt2 = new Button();
        Button bt1 = new Button();
        TextBox tbIme = new TextBox();
        TextBox tbCena = new TextBox();
        TextBox tbRedenBr = new TextBox();
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-97R3245;Initial Catalog=GymBuddy;Integrated Security=True");
        private void Dodaj_grupen_trening_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 600;
            this.ShowIcon = false;
            this.CenterToScreen();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //meni del
            Panel panel = new Panel();
            panel.Width = 200;
            panel.Height = 600;
            panel.Location = new Point(0, 0);
            panel.BackColor = Color.DimGray;
            Controls.Add(panel);

            Label lb = new Label();
            lb.Width = 200;
            lb.Height = 50;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Text = "Gym Buddy";
            lb.Font = new Font("Calibri", 15);
            lb.BackColor = Color.MediumSeaGreen;
            lb.ForeColor = Color.White;
            lb.Location = new Point(0, 0);
            panel.Controls.Add(lb);

            members.Text = "Членови";
            members.Width = 200;
            members.Height = 50;
            members.TextAlign = ContentAlignment.MiddleCenter;
            members.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/members.PNG");
            members.ImageAlign = ContentAlignment.MiddleLeft;
            members.ForeColor = Color.White;
            members.FlatStyle = FlatStyle.Flat;
            members.FlatAppearance.BorderSize = 0;
            members.Font = new Font("Calibri", 15);
            members.Location = new Point(0, 50);
            members.Click += new EventHandler(this.members_Click);
            bool buttonPressed = false;
            panel.Controls.Add(members);

            newMbr.Text = "Додај нов член";
            newMbr.Width = 200;
            newMbr.Height = 50;
            newMbr.BackColor = Color.Gray;
            newMbr.TextAlign = ContentAlignment.MiddleCenter;
            newMbr.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/add-user.PNG");
            newMbr.ImageAlign = ContentAlignment.MiddleLeft;
            newMbr.ForeColor = Color.White;
            newMbr.FlatStyle = FlatStyle.Flat;
            newMbr.FlatAppearance.BorderSize = 0;
            newMbr.Font = new Font("Calibri", 10);
            newMbr.Click += new EventHandler(this.novChlen);
            newMbr.Location = new Point(0, 100);
            newMbr.Hide();
            panel.Controls.Add(newMbr);

            izmeniMbr.Text = "Измени/Избриши член";
            izmeniMbr.Width = 200;
            izmeniMbr.Height = 50;
            izmeniMbr.BackColor = Color.Gray;
            izmeniMbr.TextAlign = ContentAlignment.MiddleRight;
            izmeniMbr.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/remove-user.PNG");
            izmeniMbr.ImageAlign = ContentAlignment.MiddleLeft;
            izmeniMbr.ForeColor = Color.White;
            izmeniMbr.FlatStyle = FlatStyle.Flat;
            izmeniMbr.FlatAppearance.BorderSize = 0;
            izmeniMbr.Font = new Font("Calibri", 10);
            izmeniMbr.Location = new Point(0, 150);
            izmeniMbr.Hide();
            izmeniMbr.Click += new EventHandler(this.IzmeniChlen);
            panel.Controls.Add(izmeniMbr);

            allMbr.Text = "Сите членови";
            allMbr.Width = 200;
            allMbr.Height = 50;
            allMbr.BackColor = Color.Gray;
            allMbr.TextAlign = ContentAlignment.MiddleCenter;
            allMbr.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/text-file.PNG");
            allMbr.ImageAlign = ContentAlignment.MiddleLeft;
            allMbr.ForeColor = Color.White;
            allMbr.FlatStyle = FlatStyle.Flat;
            allMbr.FlatAppearance.BorderSize = 0;
            allMbr.Font = new Font("Calibri", 10);
            allMbr.Location = new Point(0, 200);
            allMbr.Hide();
            allMbr.Click += new EventHandler(this.SiteChlen);
            panel.Controls.Add(allMbr);

            vrab.Text = "Вработени";
            vrab.Width = 200;
            vrab.Height = 50;
            vrab.TextAlign = ContentAlignment.MiddleCenter;
            vrab.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/vrab.PNG");
            vrab.ImageAlign = ContentAlignment.MiddleLeft;
            vrab.FlatStyle = FlatStyle.Flat;
            vrab.FlatAppearance.BorderSize = 0;
            vrab.Font = new Font("Calibri", 15);
            vrab.ForeColor = Color.White;
            vrab.Location = new Point(0, 100);
            vrab.Click += new EventHandler(this.vraboten_Click);
            bool buttonPressed1 = false;
            panel.Controls.Add(vrab);

            newVrab.Text = "Додај нов вработен";
            newVrab.Width = 200;
            newVrab.Height = 50;
            newVrab.BackColor = Color.Gray;
            newVrab.TextAlign = ContentAlignment.MiddleCenter;
            newVrab.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/add-user.PNG");
            newVrab.ImageAlign = ContentAlignment.MiddleLeft;
            newVrab.ForeColor = Color.White;
            newVrab.FlatStyle = FlatStyle.Flat;
            newVrab.FlatAppearance.BorderSize = 0;
            newVrab.Font = new Font("Calibri", 10);
            newVrab.Location = new Point(0, 150);
            newVrab.Hide();
            newVrab.Click += new EventHandler(this.novVrab);
            panel.Controls.Add(newVrab);

            izmeniVrab.Text = "Измени/Избриши вработен";
            izmeniVrab.Width = 200;
            izmeniVrab.Height = 50;
            izmeniVrab.BackColor = Color.Gray;
            izmeniVrab.TextAlign = ContentAlignment.MiddleRight;
            izmeniVrab.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/edit-user.PNG");
            izmeniVrab.ImageAlign = ContentAlignment.MiddleLeft;
            izmeniVrab.ForeColor = Color.White;
            izmeniVrab.FlatStyle = FlatStyle.Flat;
            izmeniVrab.FlatAppearance.BorderSize = 0;
            izmeniVrab.Font = new Font("Calibri", 10);
            izmeniVrab.Location = new Point(0, 200);
            izmeniVrab.Hide();
            izmeniVrab.Click += new EventHandler(this.IzmeniVrab);
            panel.Controls.Add(izmeniVrab);

            allVrab.Text = "Сите вработени";
            allVrab.Width = 200;
            allVrab.Height = 50;
            allVrab.BackColor = Color.Gray;
            allVrab.TextAlign = ContentAlignment.MiddleCenter;
            allVrab.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/text-file.PNG");
            allVrab.ImageAlign = ContentAlignment.MiddleLeft;
            allVrab.ForeColor = Color.White;
            allVrab.FlatStyle = FlatStyle.Flat;
            allVrab.FlatAppearance.BorderSize = 0;
            allVrab.Font = new Font("Calibri", 10);
            allVrab.Location = new Point(0, 250);
            allVrab.Hide();
            allVrab.Click += new EventHandler(this.SiteVrab);
            panel.Controls.Add(allVrab);

            oprema.Text = "Опрема";
            oprema.Width = 200;
            oprema.Height = 50;
            oprema.TextAlign = ContentAlignment.MiddleCenter;
            oprema.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/dumbbell.PNG");
            oprema.ImageAlign = ContentAlignment.MiddleLeft;
            oprema.FlatStyle = FlatStyle.Flat;
            oprema.FlatAppearance.BorderSize = 0;
            oprema.Font = new Font("Calibri", 15);
            oprema.ForeColor = Color.White;
            oprema.Location = new Point(0, 150);
            oprema.Click += new EventHandler(this.oprema_Click);
            bool buttonPressed2 = false;
            panel.Controls.Add(oprema);

            celaop.Text = "Постоечка опрема";
            celaop.Width = 200;
            celaop.Height = 50;
            celaop.BackColor = Color.Gray;
            celaop.TextAlign = ContentAlignment.MiddleCenter;
            celaop.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/text-file.PNG");
            celaop.ImageAlign = ContentAlignment.MiddleLeft;
            celaop.ForeColor = Color.White;
            celaop.FlatStyle = FlatStyle.Flat;
            celaop.FlatAppearance.BorderSize = 0;
            celaop.Font = new Font("Calibri", 10);
            celaop.Location = new Point(0, 200);
            celaop.Hide();
            celaop.Click += new EventHandler(this.CelaOprema);
            panel.Controls.Add(celaop);

            novaop.Text = "Додај нова опрема";
            novaop.Width = 200;
            novaop.Height = 50;
            novaop.BackColor = Color.Gray;
            novaop.TextAlign = ContentAlignment.MiddleCenter;
            novaop.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/plus.PNG");
            novaop.ImageAlign = ContentAlignment.MiddleLeft;
            novaop.ForeColor = Color.White;
            novaop.FlatStyle = FlatStyle.Flat;
            novaop.FlatAppearance.BorderSize = 0;
            novaop.Font = new Font("Calibri", 10);
            novaop.Location = new Point(0, 250);
            novaop.Hide();
            novaop.Click += new EventHandler(this.DodajNova);
            panel.Controls.Add(novaop);

            izbrisiop.Text = "Избриши опрема";
            izbrisiop.Width = 200;
            izbrisiop.Height = 50;
            izbrisiop.BackColor = Color.Gray;
            izbrisiop.TextAlign = ContentAlignment.MiddleCenter;
            izbrisiop.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/minus.PNG");
            izbrisiop.ImageAlign = ContentAlignment.MiddleLeft;
            izbrisiop.ForeColor = Color.White;
            izbrisiop.FlatStyle = FlatStyle.Flat;
            izbrisiop.FlatAppearance.BorderSize = 0;
            izbrisiop.Font = new Font("Calibri", 10);
            izbrisiop.Location = new Point(0, 300);
            izbrisiop.Hide();
            izbrisiop.Click += new EventHandler(this.Izbrishi);
            panel.Controls.Add(izbrisiop);

            proizvodi.Text = "Услуги";
            proizvodi.Width = 200;
            proizvodi.Height = 50;
            proizvodi.TextAlign = ContentAlignment.MiddleCenter;
            proizvodi.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/book.PNG");
            proizvodi.ImageAlign = ContentAlignment.MiddleLeft;
            proizvodi.FlatStyle = FlatStyle.Flat;
            proizvodi.FlatAppearance.BorderSize = 0;
            proizvodi.ForeColor = Color.White;
            proizvodi.Font = new Font("Calibri", 15);
            proizvodi.Location = new Point(0, 200);
            proizvodi.Click += new EventHandler(this.Proizvodi_Click);
            bool buttonPressed5 = false;
            panel.Controls.Add(proizvodi);

            clenskiKarti.Text = "Членски карти";
            clenskiKarti.Width = 200;
            clenskiKarti.Height = 50;
            clenskiKarti.BackColor = Color.Gray;
            clenskiKarti.TextAlign = ContentAlignment.MiddleCenter;
            clenskiKarti.ForeColor = Color.White;
            clenskiKarti.FlatStyle = FlatStyle.Flat;
            clenskiKarti.FlatAppearance.BorderSize = 0;
            clenskiKarti.Font = new Font("Calibri", 10);
            clenskiKarti.Click += new EventHandler(this.CKarti_Click);
            clenskiKarti.Location = new Point(0, 250);
            clenskiKarti.Hide();
            panel.Controls.Add(clenskiKarti);

            lcTrenizni.Text = "Персонализирани тренинзи";
            lcTrenizni.Width = 200;
            lcTrenizni.Height = 50;
            lcTrenizni.BackColor = Color.Gray;
            lcTrenizni.TextAlign = ContentAlignment.MiddleCenter;
            lcTrenizni.ForeColor = Color.White;
            lcTrenizni.FlatStyle = FlatStyle.Flat;
            lcTrenizni.FlatAppearance.BorderSize = 0;
            lcTrenizni.Font = new Font("Calibri", 10);
            lcTrenizni.Location = new Point(0, 300);
            lcTrenizni.Hide();
            lcTrenizni.Click += new EventHandler(this.PSTreninzi_Click);
            panel.Controls.Add(lcTrenizni);

            grTrenizi.Text = "Групни Тренинзи";
            grTrenizi.Width = 200;
            grTrenizi.Height = 50;
            grTrenizi.BackColor = Color.Gray;
            lcTrenizni.TextAlign = ContentAlignment.MiddleCenter;
            grTrenizi.ForeColor = Color.White;
            grTrenizi.FlatStyle = FlatStyle.Flat;
            grTrenizi.FlatAppearance.BorderSize = 0;
            grTrenizi.Font = new Font("Calibri", 10);
            grTrenizi.Location = new Point(0, 350);
            grTrenizi.Hide();
            grTrenizi.Click += new EventHandler(this.GRTrenizi_Click);
            panel.Controls.Add(grTrenizi);

            suplementi.Text = "Суплементи";
            suplementi.Width = 200;
            suplementi.Height = 50;
            suplementi.BackColor = Color.Gray;
            lcTrenizni.TextAlign = ContentAlignment.MiddleCenter;
            suplementi.ForeColor = Color.White;
            suplementi.FlatStyle = FlatStyle.Flat;
            suplementi.FlatAppearance.BorderSize = 0;
            suplementi.Font = new Font("Calibri", 10);
            suplementi.Location = new Point(0, 400);
            suplementi.Hide();
            suplementi.Click += new EventHandler(this.Suplementi_Click);
            panel.Controls.Add(suplementi);

            izlez.Text = "Излез";
            izlez.Width = 200;
            izlez.Height = 50;
            izlez.TextAlign = ContentAlignment.MiddleCenter;
            izlez.Image = Image.FromFile("C:/Users/abane/Pictures/GymBuddy/exit3.PNG");
            izlez.ImageAlign = ContentAlignment.MiddleLeft;
            izlez.FlatStyle = FlatStyle.Flat;
            izlez.FlatAppearance.BorderSize = 0;
            izlez.ForeColor = Color.White;
            izlez.Font = new Font("Calibri", 15);
            izlez.Location = new Point(0, 250);
            izlez.Click += new EventHandler(this.Izlez_Click);
            bool buttonPressed4 = false;
            panel.Controls.Add(izlez);

            logout.Text = "Одлогирај се";
            logout.Width = 200;
            logout.Height = 50;
            logout.BackColor = Color.Gray;
            logout.TextAlign = ContentAlignment.MiddleLeft;
            logout.ForeColor = Color.White;
            logout.FlatStyle = FlatStyle.Flat;
            logout.FlatAppearance.BorderSize = 0;
            logout.Font = new Font("Calibri", 10);
            logout.Location = new Point(0, 300);
            logout.Hide();
            logout.Click += new EventHandler(this.logout_Click);
            panel.Controls.Add(logout);

            exit.Text = "Исклучи ја апликацијта";
            exit.Width = 200;
            exit.Height = 50;
            exit.BackColor = Color.Gray;
            exit.TextAlign = ContentAlignment.MiddleLeft;
            exit.ForeColor = Color.White;
            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 0;
            exit.Font = new Font("Calibri", 10);
            exit.Location = new Point(0, 350);
            exit.Hide();
            exit.Click += new EventHandler(this.exit_Click);
            panel.Controls.Add(exit);

            //naslov del

            Panel panel2 = new Panel();
            panel2.Width = 800;
            panel2.Height = 50;
            panel2.Location = new Point(200, 0);
            panel2.BackColor = Color.DarkSeaGreen;
            Controls.Add(panel2);

            PictureBox pic = new PictureBox();
            pic.Height = 20;
            pic.Width = 20;
            pic.Location = new Point(10, 15);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.ImageLocation = "C:/Users/abane/Pictures/GymBuddy/menu.PNG";
            panel2.Controls.Add(pic);

            Label lbNaslov = new Label();
            lbNaslov.Width = 300;
            lbNaslov.Height = 50;
            lbNaslov.TextAlign = ContentAlignment.MiddleCenter;
            lbNaslov.Text = "GYM Buddy - Menagement System";
            lbNaslov.Font = new Font("Calibri", 15);
            lbNaslov.ForeColor = Color.White;
            lbNaslov.Location = new Point(240, 0);
            panel2.Controls.Add(lbNaslov);

            //Sredina del

            Panel panel1 = new Panel();
            panel1.Width = 800;
            panel1.Height = 550;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(200, 50);
            Controls.Add(panel1);

            Label lb1 = new Label();
            lb1.Text = "Додај нов тип групен тренинг";
            lb1.Width = 300;
            lb1.Height = 50;
            lb1.TextAlign = ContentAlignment.MiddleLeft;
            lb1.ForeColor = Color.Black;
            lb1.Font = new Font("Calibri", 15);
            lb1.Location = new Point(250, 20);
            panel1.Controls.Add(lb1);

            Label lbIme = new Label();
            lbIme.Text = "Внеси Име";
            lbIme.TextAlign = ContentAlignment.MiddleRight;
            lbIme.Width = 100;
            lbIme.ForeColor = Color.Black;
            lbIme.Font = new Font("Calibri", 10);
            lbIme.Location = new Point(70, 100);
            panel1.Controls.Add(lbIme);

            Label lbCena = new Label();
            lbCena.Text = "Внеси Цена";
            lbCena.Width = 100;
            lbCena.TextAlign = ContentAlignment.MiddleRight;
            lbCena.ForeColor = Color.Black;
            lbCena.Font = new Font("Calibri", 10);
            lbCena.Location = new Point(70, 150);
            panel1.Controls.Add(lbCena);

            Label lbRedenBr = new Label();
            lbRedenBr.Text = "Внеси Реден Број";
            lbRedenBr.Width = 150;
            lbRedenBr.TextAlign = ContentAlignment.MiddleRight;
            lbRedenBr.ForeColor = Color.Black;
            lbRedenBr.Font = new Font("Calibri", 10);
            lbRedenBr.Location = new Point(40, 200);
            panel1.Controls.Add(lbRedenBr);

            tbIme.Width = 350;
            tbIme.Location = new Point(200, 100);
            panel1.Controls.Add(tbIme);

            tbCena.Width = 350;
            tbCena.Location = new Point(200, 150);
            panel1.Controls.Add(tbCena);

            tbRedenBr.Width = 350;
            tbRedenBr.Location = new Point(200, 200);
            panel1.Controls.Add(tbRedenBr);

            bt1.Text = "Зачувај";
            bt1.ForeColor = Color.Black;
            bt1.Width = 100;
            bt1.Height = 30;
            bt1.Location = new Point(150, 350);
            bt1.Click += new EventHandler(this.btZachuvaj_Click);
            panel1.Controls.Add(bt1);

            bt2.Text = "Назад";
            bt2.ForeColor = Color.Black;
            bt2.Width = 100;
            bt2.Height = 30;
            bt2.Location = new Point(300, 350);
            bt2.Click += new EventHandler(this.btNazad_Click);
            panel1.Controls.Add(bt2);
        }
        public void members_Click(object sender, EventArgs e)
        {
            if (!buttonPressed)
            {
                buttonPressed = true;
                newMbr.Show();
                izmeniMbr.Show();
                allMbr.Show();
                vrab.Location = new Point(0, 250);
                oprema.Location = new Point(0, 300);
                proizvodi.Location = new Point(0, 350);
                izlez.Location = new Point(0, 400);
            }
            else
            {
                buttonPressed = false;
                newMbr.Hide();
                izmeniMbr.Hide();
                allMbr.Hide();
                vrab.Location = new Point(0, 100);
                oprema.Location = new Point(0, 150);
                proizvodi.Location = new Point(0, 200);
                izlez.Location = new Point(0, 250);
            }

        }

        public void novChlen(object sender, EventArgs e)
        {
            this.Hide();
            Додај_нов_член novchlen = new Додај_нов_член();
            novchlen.FormClosed += (s, args) => this.Close();
            novchlen.Show();
        }
        public void IzmeniChlen(object sender, EventArgs e)
        {
            this.Hide();
            Измени_член izmenichlen = new Измени_член();
            izmenichlen.FormClosed += (s, args) => this.Close();
            izmenichlen.Show();
        }
        public void SiteChlen(object sender, EventArgs e)
        {
            this.Hide();
            Сите_членови sitechlen = new Сите_членови();
            sitechlen.FormClosed += (s, args) => this.Close();
            sitechlen.Show();

        }
        public void vraboten_Click(object sender, EventArgs e)
        {
            if (!buttonPressed1)
            {
                buttonPressed1 = true;
                newVrab.Show();
                izmeniVrab.Show();
                allVrab.Show();
                oprema.Location = new Point(0, 300);
                proizvodi.Location = new Point(0, 350);
                izlez.Location = new Point(0, 400);
            }
            else
            {
                buttonPressed1 = false;
                newVrab.Hide();
                izmeniVrab.Hide();
                allVrab.Hide();
                oprema.Location = new Point(0, 150);
                proizvodi.Location = new Point(0, 200);
                izlez.Location = new Point(0, 250);
            }

        }
        public void novVrab(object sender, EventArgs e)
        {
            this.Hide();
            Додај_нов_вработен novvrab = new Додај_нов_вработен();
            novvrab.FormClosed += (s, args) => this.Close();
            novvrab.Show();
        }
        public void IzmeniVrab(object sender, EventArgs e)
        {
            this.Hide();
            Измени_вработен izmenivrab = new Измени_вработен();
            izmenivrab.FormClosed += (s, args) => this.Close();
            izmenivrab.Show();
        }
        public void SiteVrab(object sender, EventArgs e)
        {
            this.Hide();
            Сите_вработени sitevrab = new Сите_вработени();
            sitevrab.FormClosed += (s, args) => this.Close();
            sitevrab.Show();
        }
        public void oprema_Click(object sender, EventArgs e)
        {
            if (!buttonPressed2)
            {
                buttonPressed2 = true;
                celaop.Show();
                novaop.Show();
                izbrisiop.Show();
                proizvodi.Location = new Point(0, 350);
                izlez.Location = new Point(0, 400);
            }
            else
            {
                buttonPressed2 = false;
                celaop.Hide();
                novaop.Hide();
                izbrisiop.Hide();
                proizvodi.Location = new Point(0, 200);
                izlez.Location = new Point(0, 250);
            }
        }
        public void CelaOprema(object sender, EventArgs e)
        {
            this.Hide();
            Цела_опрема celaoprema = new Цела_опрема();
            celaoprema.FormClosed += (s, args) => this.Close();
            celaoprema.Show();
        }
        public void DodajNova(object sender, EventArgs e)
        {
            this.Hide();
            Додај_нова_опрема novaoprema = new Додај_нова_опрема();
            novaoprema.FormClosed += (s, args) => this.Close();
            novaoprema.Show();
        }
        public void Izbrishi(object sender, EventArgs e)
        {
            this.Hide();
            Избриши_опрема izbrishioprema = new Избриши_опрема();
            izbrishioprema.FormClosed += (s, args) => this.Close();
            izbrishioprema.Show();
        }
        public void Proizvodi_Click(object sender, EventArgs e)
        {
            if (!buttonPressed5)
            {
                buttonPressed5 = true;
                clenskiKarti.Show();
                lcTrenizni.Show();
                grTrenizi.Show();
                suplementi.Show();
                izlez.Location = new Point(0, 450);
            }
            else
            {
                buttonPressed5 = false;
                clenskiKarti.Hide();
                lcTrenizni.Hide();
                grTrenizi.Hide();
                suplementi.Hide();
                izlez.Location = new Point(0, 250);
            }
        }
        public void CKarti_Click(object sender, EventArgs e)
        {
            this.Hide();
            Членски_Карти chlenskiKarti = new Членски_Карти();
            chlenskiKarti.FormClosed += (s, args) => this.Close();
            chlenskiKarti.Show();
        }
        public void PSTreninzi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Персонализирани_тренизни licnitrninzi = new Персонализирани_тренизни();
            licnitrninzi.FormClosed += (s, args) => this.Close();
            licnitrninzi.Show();
        }
        public void GRTrenizi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Групни_тренизи grupnitreninzi = new Групни_тренизи();
            grupnitreninzi.FormClosed += (s, args) => this.Close();
            grupnitreninzi.Show();
        }
        public void Suplementi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Суплементи suplementi = new Суплементи();
            suplementi.FormClosed += (s, args) => this.Close();
            suplementi.Show();
        }
        public void Izlez_Click(object sender, EventArgs e)
        {
            if (!buttonPressed4)
            {
                buttonPressed4 = true;
                logout.Show();
                exit.Show();
            }
            else
            {
                buttonPressed4 = false;
                logout.Hide();
                exit.Hide();
            }
        }
        public void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.FormClosed += (s, args) => this.Close();
            lf.Show();
        }
        public void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали си сигурен дека излегуваш од програмата?", "Излез", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        public void btZachuvaj_Click(object sender, EventArgs e)
        {
            if (tbRedenBr.Text != "" && tbIme.Text != "" && tbCena.Text != "")
            {
                conn.Open();
                string query = "insert into Grupni_Treninzi(ID,Ime,Cena) " +
                    "values (@tbRedenBr, @tbIme, @tbCena)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tbRedenBr", tbRedenBr.Text);
                cmd.Parameters.AddWithValue("@tbIme", tbIme.Text);
                cmd.Parameters.AddWithValue("@tbCena", tbCena.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Успешно се внесени податоците");
                tbRedenBr.Text = "";
                tbIme.Text = "";
                tbCena.Text = "";
            }
            else
                MessageBox.Show("Грешка при внесување податоци");

        }
        public void btNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Групни_тренизи grtreninzi = new Групни_тренизи();
            grtreninzi.FormClosed += (s, args) => this.Close();
            grtreninzi.Show();
        }
    }
}
