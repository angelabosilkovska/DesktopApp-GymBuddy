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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        TextBox tb1 = new TextBox();
        TextBox tb2 = new TextBox();
        Button bt1 = new Button();
        Button bt2 = new Button();
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-97R3245;Initial Catalog=GymBuddy;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 560;
            this.Height = 300;
            this.BackColor = Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();
            this.ShowIcon = false;

            PictureBox pic = new PictureBox();
            pic.Height = 200;
            pic.Width = 220;
            pic.Location = new Point(40, 30);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.ImageLocation = "C:/Users/abane/Pictures/GymBuddy/GymBuddyLogo.PNG";
            Controls.Add(pic);

            Label lbNaslov = new Label();
            lbNaslov.Text = "GYM BUDDY";
            lbNaslov.Width = 150;
            lbNaslov.Location = new Point(340, 20);
            lbNaslov.ForeColor = Color.White;
            lbNaslov.Font = new Font("Calibri", 17, FontStyle.Bold);
            Controls.Add(lbNaslov);

            Label lb = new Label();
            lb.Text = "Логирај се";
            lb.Width = 150;
            lb.Location = new Point(360, 60);
            lb.ForeColor = Color.White;
            lb.Font = new Font("Calibri", 12, FontStyle.Bold);
            Controls.Add(lb);

            PictureBox pic1 = new PictureBox();
            pic1.Height = 20;
            pic1.Width = 20;
            pic1.Location = new Point(310, 100);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.ImageLocation = "C:/Users/abane/Pictures/GymBuddy/user.PNG";
            Controls.Add(pic1);

            PictureBox pic2 = new PictureBox();
            pic2.Height = 20;
            pic2.Width = 20;
            pic2.Location = new Point(310, 150);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.ImageLocation = "C:/Users/abane/Pictures/GymBuddy/passvord.PNG";
            Controls.Add(pic2);

            tb1.Width = 150;
            tb1.Location = new Point(340, 100);
            Controls.Add(tb1);

            tb2.Width = 150;
            tb2.Location = new Point(340, 150);
            Controls.Add(tb2);

            bt1.Width = 50;
            bt1.Height = 30;
            bt1.Text = "ОК";
            bt1.Location = new Point(310, 200);
            bt1.Font = new Font("Calibri",9);
            bt1.ForeColor = Color.White;
            bt1.Click += new EventHandler(this.login);
            Controls.Add(bt1);

            bt2.Width = 100;
            bt2.Height = 30;
            bt2.Text = "Регистрирај се";
            bt2.Location = new Point(380, 200);
            bt2.ForeColor = Color.White;
            bt2.Font = new Font("Calibri",9);
            bt2.Click += new EventHandler(this.registracija);
            Controls.Add(bt2); 
        }
        public void login(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(*) from Vraboteni where [Korisnichko ime]=@tb1 and Lozinka=@tb2", conn);
            cmd.Parameters.AddWithValue("@tb1", tb1.Text);
            cmd.Parameters.AddWithValue("@tb2", tb2.Text);
            int res;
            res = (int)cmd.ExecuteScalar();
            conn.Close();
            if (res == 1)
            {
                this.Hide();
                MeniForma mn = new MeniForma();
                mn.FormClosed += (s, args) => this.Close();
                mn.Show();
            }
            else
            {
                tb1.Text = "";
                tb2.Text = "";
                MessageBox.Show("Грешка при логирање");
            }
        }
      
        public void registracija(object sender, EventArgs e)
        {
            this.Hide();
            Registracija rg = new Registracija();
            rg.FormClosed += (s, args) => this.Close();
            rg.Show();
        }
    }
}
