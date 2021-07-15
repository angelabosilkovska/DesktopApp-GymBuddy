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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }
        TextBox tbIme = new TextBox();
        TextBox tbKIme = new TextBox();
        TextBox tbPrezime = new TextBox();
        TextBox tbPass = new TextBox();
        TextBox tbTel = new TextBox();
        TextBox tbAdr = new TextBox();
        TextBox tbEmail = new TextBox();
        TextBox tbEMBG = new TextBox();
        Button bt1 = new Button();
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-97R3245;Initial Catalog=GymBuddy;Integrated Security=True");
        private void Registracija_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 700;
            this.BackColor = Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();
            this.ShowIcon = false;

            PictureBox pic = new PictureBox();
            pic.Height = 700;
            pic.Width = 300;
            pic.Location = new Point(0, 0);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.ImageLocation = "C:/Users/abane/Pictures/GymBuddy/image.JPG";
            Controls.Add(pic);

            Label lb1 = new Label();
            lb1.Text = "Регистрирај се";
            lb1.Width=150;
            lb1.ForeColor = Color.White;
            lb1.Font = new Font("Calibri", 15, FontStyle.Bold);
            lb1.Location = new Point(370, 30);
            Controls.Add(lb1);

            Label lbIme = new Label();
            lbIme.Text = "Внеси Име";
            lbIme.Width = 100;
            lbIme.ForeColor = Color.White;
            lbIme.Font = new Font("Calibri", 10);
            lbIme.Location = new Point(330, 70);
            Controls.Add(lbIme);

            Label lbPrezime = new Label();
            lbPrezime.Text = "Внеси Презиме";
            lbPrezime.Width = 100;
            lbPrezime.ForeColor = Color.White;
            lbPrezime.Font = new Font("Calibri", 10);
            lbPrezime.Location = new Point(330, 140);
            Controls.Add(lbPrezime);

            Label lbKIme = new Label();
            lbKIme.Text = "Внеси Корисничко Име";
            lbKIme.Width = 150;
            lbKIme.ForeColor = Color.White;
            lbKIme.Font = new Font("Calibri", 10);
            lbKIme.Location = new Point(330, 210);
            Controls.Add(lbKIme);

            Label lbPass = new Label();
            lbPass.Text = "Внеси Лозинка";
            lbPass.Width = 100;
            lbPass.ForeColor = Color.White;
            lbPass.Font = new Font("Calibri", 10);
            lbPass.Location = new Point(330, 280);
            Controls.Add(lbPass);
            
            Label lbTel = new Label();
            lbTel.Text = "Внеси Телефон";
            lbTel.Width = 100;
            lbTel.ForeColor = Color.White;
            lbTel.Font = new Font("Calibri", 10);
            lbTel.Location = new Point(330, 350);
            Controls.Add(lbTel); 

            Label lbAdr = new Label();
            lbAdr.Text = "Внеси Адреса";
            lbAdr.Width = 100;
            lbAdr.ForeColor = Color.White;
            lbAdr.Font = new Font("Calibri", 10);
            lbAdr.Location = new Point(330, 420);
            Controls.Add(lbAdr);

            Label lbEmail = new Label();
            lbEmail.Text = "Внеси E-mail";
            lbEmail.Width = 100;
            lbEmail.ForeColor = Color.White;
            lbEmail.Font = new Font("Calibri", 10);
            lbEmail.Location = new Point(330, 490);
            Controls.Add(lbEmail);

            Label lbEMBG = new Label();
            lbEMBG.Text = "Внеси ЕМБГ";
            lbEMBG.Width = 100;
            lbEMBG.ForeColor = Color.White;
            lbEMBG.Font = new Font("Calibri", 10);
            lbEMBG.Location = new Point(330, 560);
            Controls.Add(lbEMBG);

            tbIme.Width = 200;
            tbIme.Location = new Point(330, 100);
            Controls.Add(tbIme);
          
            tbPrezime.Width = 200;
            tbPrezime.Location = new Point(330, 170);
            Controls.Add(tbPrezime);
            
            tbKIme.Width = 200;
            tbKIme.Location = new Point(330, 240);
            Controls.Add(tbKIme);
            
            tbPass.Width = 200;
            tbPass.Location = new Point(330, 310);
            Controls.Add(tbPass);
            
            tbTel.Width = 200;
            tbTel.Location = new Point(330, 380);
            Controls.Add(tbTel);
            
            tbAdr.Width = 200;
            tbAdr.Location = new Point(330, 450);
            Controls.Add(tbAdr);

            tbEmail.Width = 200;
            tbEmail.Location = new Point(330, 520);
            Controls.Add(tbEmail);

            tbEMBG.Width = 200;
            tbEMBG.Location = new Point(330, 590);
            Controls.Add(tbEMBG);
            
            bt1.Text = "Креирај профил";
            bt1.ForeColor = Color.White;
            bt1.Width = 100;
            bt1.Height = 30;
            bt1.Location = new Point(330, 620);
            bt1.Click += new EventHandler(this.bt1_Click);
            Controls.Add(bt1);

            Button bt2 = new Button();
            bt2.Text = "Назад";
            bt2.ForeColor = Color.White;
            bt2.Width = 70;
            bt2.Height = 30;
            bt2.Location = new Point(450, 620);
            bt2.Click += new EventHandler(this.bt2_Click);
            Controls.Add(bt2);

        }
        public void bt1_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "" && tbPrezime.Text != "" && tbKIme.Text != "" && tbPass.Text != "" && tbAdr.Text != "" && tbEmail.Text != "" && tbTel.Text != "" && tbEMBG.Text != "")
            { 
            conn.Open();
            string query = "insert into Vraboteni(Ime,Prezime,[Korisnichko ime],Lozinka,Telefon,Adresa,[E-mail],EMBG) " +
                "values (@tbIme,@tbPrezime, @tbKIme, @tbPass, @tbTel, @tbAdr, @tbEmail,@tbEMBG)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tbIme", tbIme.Text);
            cmd.Parameters.AddWithValue("@tbKIme", tbKIme.Text);
            cmd.Parameters.AddWithValue("@tbPrezime", tbPrezime.Text);
            cmd.Parameters.AddWithValue("@tbPass", tbPass.Text);
            cmd.Parameters.AddWithValue("@tbTel", tbTel.Text);
            cmd.Parameters.AddWithValue("@tbAdr", tbAdr.Text);
            cmd.Parameters.AddWithValue("@tbEmail", tbEmail.Text);
            cmd.Parameters.AddWithValue("@tbEMBG", tbEMBG.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Успешно се внесени податоците");
            tbIme.Text = "";
            tbKIme.Text = "";
            tbPrezime.Text = "";
            tbPass.Text = "";
            tbTel.Text = "";
            tbAdr.Text = "";
            tbEmail.Text = "";
            tbEMBG.Text = "";
            }
        else
        MessageBox.Show("Грешка при внесување податоци");
        }
        public void bt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.FormClosed += (s, args) => this.Close();
            lf.Show();
        }
    }
}
