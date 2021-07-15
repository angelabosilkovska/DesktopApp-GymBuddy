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
    public partial class Izmeni_pTreninzi : Form
    {
        public Izmeni_pTreninzi()
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
        Label lb1 = new Label();
        ComboBox cbox = new ComboBox();
        Button bt1 = new Button();
        Button bt2 = new Button();
        Label lb2 = new Label();
        Label lb3 = new Label();
        Label lb5 = new Label();
        Label lb7 = new Label();
        Label lb8 = new Label();
        Button bt3 = new Button();
        Button bt4 = new Button();
        TextBox tbrb = new TextBox();
        TextBox tbNovoIme = new TextBox();
        TextBox tbNovaCena = new TextBox();
        Panel panel2 = new Panel();
        DataGrid grid = new DataGrid();
        private BindingSource bindingSource = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-97R3245;Initial Catalog=GymBuddy;Integrated Security=True");
        private void Izmeni_pTreninzi_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 600;
            this.ShowIcon = false;
            this.CenterToScreen();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //meni
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

            Panel panel1 = new Panel();
            panel1.Width = 800;
            panel1.Height = 50;
            panel1.Location = new Point(200, 0);
            panel1.BackColor = Color.DarkSeaGreen;
            Controls.Add(panel1);

            PictureBox pic = new PictureBox();
            pic.Height = 20;
            pic.Width = 20;
            pic.Location = new Point(10, 15);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.ImageLocation = "C:/Users/abane/Pictures/GymBuddy/menu.PNG";
            panel1.Controls.Add(pic);

            Label lbNaslov = new Label();
            lbNaslov.Width = 300;
            lbNaslov.Height = 50;
            lbNaslov.TextAlign = ContentAlignment.MiddleCenter;
            lbNaslov.Text = "GYM Buddy - Menagement System";
            lbNaslov.Font = new Font("Calibri", 15);
            lbNaslov.ForeColor = Color.White;
            lbNaslov.Location = new Point(240, 0);
            panel1.Controls.Add(lbNaslov);

            //sredina del
            //forma1

            panel2.Width = 800;
            panel2.Height = 550;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(200, 50);
            Controls.Add(panel2);

            lb1.Text = "Измени Личен Тренинг";
            lb1.ForeColor = Color.Black;
            lb1.Width = 250;
            lb1.Height = 40;
            lb1.TextAlign = ContentAlignment.MiddleLeft;
            lb1.Font = new Font("Calibri", 15);
            lb1.Location = new Point(50, 15);
            panel2.Controls.Add(lb1);

            grid.Height = 200;
            grid.Width = 550;
            grid.Location = new Point(50, 60);
            grid.BackColor = Color.LightGray;
            grid.ForeColor = Color.Black;
            grid.GridLineColor = Color.Black;
            grid.DataSource = bindingSource;
            conn.Open();
            dataAdapter = new SqlDataAdapter("select ID AS РеденБрој, Ime AS Име, Cena AS Цена from Personalizirani_Treninzi", conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            grid.ReadOnly = true;
            bindingSource.DataSource = table;
            conn.Close();
            panel2.Controls.Add(grid);

            lb8.Text = "Внесете реден број";
            lb8.Width = 250;
            lb8.TextAlign = ContentAlignment.MiddleLeft;
            lb8.ForeColor = Color.Black;
            lb8.Font = new Font("Calibri", 13);
            lb8.Location = new Point(50, 290);
            panel2.Controls.Add(lb8);

            tbrb.Width = 200;
            tbrb.Location = new Point(50, 330);
            panel2.Controls.Add(tbrb);

            lb7.Text = "Избери што да измениш";
            lb7.ForeColor = Color.Black;
            lb7.Width = 250;
            lb7.Height = 40;
            lb7.TextAlign = ContentAlignment.MiddleLeft;
            lb7.Font = new Font("Calibri", 13);
            lb7.Location = new Point(400, 290);
            panel2.Controls.Add(lb7);

            cbox.Width = 150;
            cbox.Text = "Избери";
            cbox.Location = new Point(400, 330);
            cbox.BackColor = Color.White;
            cbox.ForeColor = Color.Black;
            cbox.Items.Add("Име");
            cbox.Items.Add("Цена");
            panel2.Controls.Add(cbox);

            bt1.Text = "Избери";
            bt1.ForeColor = Color.Black;
            bt1.Width = 100;
            bt1.Height = 30;
            bt1.Location = new Point(200, 390);
            bt1.Click += new EventHandler(this.Izberi_Click);
            panel2.Controls.Add(bt1);

            bt2.Text = "Назад";
            bt2.ForeColor = Color.Black;
            bt2.Width = 100;
            bt2.Height = 30;
            bt2.Location = new Point(350, 390);
            bt2.Click += new EventHandler(this.Nazad_Click);
            panel2.Controls.Add(bt2);

            //forma2

            lb2.Text = "Измени Име";
            lb2.Width = 250;
            lb2.Height = 40;
            lb2.ForeColor = Color.Black;
            lb2.Font = new Font("Calibri", 17);
            lb2.Location = new Point(150, 40);
            lb2.Hide();
            panel2.Controls.Add(lb2);

            lb3.Text = "Измени Цена";
            lb3.Width = 250;
            lb3.Height = 40;
            lb3.ForeColor = Color.Black;
            lb3.Font = new Font("Calibri", 17);
            lb3.Location = new Point(150, 40);
            lb3.Hide();
            panel2.Controls.Add(lb3);

            lb5.Text = "Внеси нов податок";
            lb5.Width = 200;
            lb5.Height = 40;
            lb5.ForeColor = Color.Black;
            lb5.Font = new Font("Calibri", 15);
            lb5.Location = new Point(50, 100);
            lb5.Hide();
            panel2.Controls.Add(lb5);

            tbNovoIme.Width = 200;
            tbNovoIme.Location = new Point(250, 110);
            tbNovoIme.Hide();
            panel2.Controls.Add(tbNovoIme);

            tbNovaCena.Width = 200;
            tbNovaCena.Location = new Point(250, 110);
            tbNovaCena.Hide();
            panel2.Controls.Add(tbNovaCena);

            bt3.Text = "Зачувај";
            bt3.ForeColor = Color.Black;
            bt3.Width = 100;
            bt3.Height = 30;
            bt3.Location = new Point(100, 170);
            bt3.Hide();
            bt3.Click += new EventHandler(this.Zachuvaj_Click);
            panel2.Controls.Add(bt3);

            bt4.Text = "Назад";
            bt4.ForeColor = Color.Black;
            bt4.Width = 100;
            bt4.Height = 30;
            bt4.Location = new Point(250, 170);
            bt4.Hide();
            bt4.Click += new EventHandler(this.Nazad2_Click);
            panel2.Controls.Add(bt4);
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
        public void Izberi_Click(object sender, EventArgs e)
        {
            lb1.Hide();
            grid.Hide();
            lb8.Hide();
            tbrb.Hide();
            lb7.Hide();
            cbox.Hide();
            bt1.Hide();
            bt2.Hide();

            bt3.Show();
            bt4.Show();
            lb5.Show();

            if (cbox.SelectedItem.Equals("Име"))
            {
                lb2.Show();
                tbNovoIme.Show();
            }
            if (cbox.SelectedItem.Equals("Цена"))
            {
                lb3.Show();
                tbNovaCena.Show();
            }
            
        }
        public void Zachuvaj_Click(object sender, EventArgs e)
        {
            if (tbNovoIme.Text != "")
            {
                conn.Open();
                string query = "Update Personalizirani_Treninzi set Ime=@tbNovoIme where ID = @tbrb";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@tbrb", SqlDbType.Int).Value = Convert.ToInt32(tbrb.Text);
                cmd.Parameters.Add("@tbNovoIme", tbNovoIme.Text);
                cmd.ExecuteNonQuery();

                dataAdapter = new SqlDataAdapter("select ID AS РеденБрој, Ime AS Име, Cena AS Цена from Personalizirani_Treninzi", conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder();
                DataTable tabela = new DataTable();
                tabela.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(tabela);
                bindingSource.DataSource = tabela;
                conn.Close();
                panel2.Controls.Add(grid);
                MessageBox.Show("Успешно");
                tbNovoIme.Text = "";
                tbrb.Text = "";
            }
            else
          if (tbNovaCena.Text != "")
            {
                conn.Open();
                string query = "Update Personalizirani_Treninzi set Cena=@tbNovaCena where ID = @tbrb";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@tbrb", SqlDbType.Int).Value = Convert.ToInt32(tbrb.Text);
                cmd.Parameters.Add("@tbNovaCena", tbNovaCena.Text);
                cmd.ExecuteNonQuery();

                dataAdapter = new SqlDataAdapter("select ID AS РеденБрој, Ime AS Име, Cena AS Цена from Personalizirani_Treninzi", conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder();
                DataTable tabela = new DataTable();
                tabela.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(tabela);
                bindingSource.DataSource = tabela;
                conn.Close();
                panel2.Controls.Add(grid);
                MessageBox.Show("Успешно");
                tbNovaCena.Text = "";
                tbrb.Text = "";
            }

            else
            {
                MessageBox.Show("Грешка", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Персонализирани_тренизни ptreninzi = new Персонализирани_тренизни();
            ptreninzi.FormClosed += (s, args) => this.Close();
            ptreninzi.Show();
        }
        public void Nazad2_Click(object sender, EventArgs e)
        {
            lb1.Show();
            grid.Show();
            lb8.Show();
            tbrb.Show();
            lb7.Show();
            cbox.Show();
            bt1.Show();
            bt2.Show();

            bt3.Hide();
            bt4.Hide();
            lb5.Hide();
            tbNovoIme.Hide();
            tbNovaCena.Hide();
            lb2.Hide();
            lb3.Hide();
        }
    }
}
