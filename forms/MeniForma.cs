using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Buddy_App
{
    public partial class MeniForma : Form
    {
        public MeniForma()
        {
            InitializeComponent();
        }

        private void MeniForma_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 600;
            this.ShowIcon = false;
            this.Text = "Gym Buddy";

            Panel panel = new Panel();
            panel.Width = 200;
            panel.Height = 600;
            panel.Location = new Point(0, 0);
            panel.BackColor = Color.LightSeaGreen;
            Controls.Add(panel);

            Button members = new Button();
            members.Text = "Членови";
            members.Width = 200;
            members.Height = 50;
            members.ForeColor = Color.White;
            members.BackColor = Color.LightGreen;
            members.Font = new Font("Calibri", 20);
            members.Location = new Point(0, 0);
            members.Click += new EventHandler(this.members_Click);
            panel.Controls.Add(members);

              Button newMbr = new Button();
              newMbr.Text = "Додај нов член";
              newMbr.Click += new EventHandler(this.novChlen);
              panel.Controls.Add(newMbr);

              Button izmeniMbr = new Button();
              izmeniMbr.Text = "Измени/Избриши член";
              izmeniMbr.Click += new EventHandler(this.IzmeniChlen);
              panel.Controls.Add(izmeniMbr);

              Button allMbr = new Button();
              allMbr.Text = "Погледни ги сите членови";
              allMbr.Click += new EventHandler(this.SiteChlen);
              panel.Controls.Add(allMbr);

            Button vrab = new Button();
            vrab.Text = "Вработени";
            vrab.Width = 200;
            vrab.Height = 50;
            vrab.Font = new Font("Calibri", 20);
            vrab.ForeColor = Color.White;
            vrab.Location = new Point(0, 50);
            panel.Controls.Add(vrab);

              Button newVrab = new Button();
              newVrab.Text = "Додај нов вработен";
              newVrab.Click += new EventHandler(this.novVrab);
              panel.Controls.Add(newVrab);

              Button izmeniVrab = new Button();
              izmeniVrab.Text = "Измени/Избриши вработен";
              izmeniVrab.Click += new EventHandler(this.IzmeniVrab);
              panel.Controls.Add(izmeniVrab);

              Button allVrab = new Button();
              allVrab.Text = "Погледни ги сите вработени";
              allVrab.Click += new EventHandler(this.SiteVrab);
              panel.Controls.Add(allVrab);

            Button oprema = new Button();
            oprema.Text = "Опрема";
            oprema.Width = 200;
            oprema.Height = 50;
            oprema.Font = new Font("Calibri", 20);
            oprema.ForeColor = Color.White;
            oprema.Location = new Point(0, 100);
            panel.Controls.Add(oprema);

              Button celaop = new Button();
              celaop.Text = "Постоечка опрема";
              celaop.Click += new EventHandler(this.CelaOprema);
              panel.Controls.Add(celaop);

              Button novaop = new Button();
              novaop.Text = "Додај нова опрема";
              novaop.Click += new EventHandler(this.DodajNova);
              panel.Controls.Add(novaop);

              Button izbrisiop = new Button();
              izbrisiop.Text = "Избриши опрема";
              izbrisiop.Click += new EventHandler(this.Izbrishi);
              panel.Controls.Add(izbrisiop);

            Button raspored = new Button();
            raspored.Text = "Распоред";
            raspored.Width = 200;
            raspored.Height = 50;
            raspored.Font = new Font("Calibri", 20);
            raspored.ForeColor = Color.White;
            raspored.Location = new Point(0, 150);
            panel.Controls.Add(raspored);

              Button grupnitreninzi = new Button();
              grupnitreninzi.Text = "Сите групни тренинзи";
              grupnitreninzi.Click += new EventHandler(this.Sitetreninzi);
              panel.Controls.Add(grupnitreninzi);

              Button aerobik = new Button();
              aerobik.Text = "Аеробик";
              aerobik.Click += new EventHandler(this.Aerobik);
              panel.Controls.Add(aerobik);

              Button hit = new Button();
              hit.Text = "HIIT";
              hit.Click += new EventHandler(this.HIIT);
              panel.Controls.Add(hit);

              Button yoga = new Button();
              yoga.Text = "Јога";
              yoga.Click += new EventHandler(this.Joga);
              panel.Controls.Add(yoga);

              Button pilates = new Button();
              pilates.Text = "Пилатес";
              pilates.Click += new EventHandler(this.Pilates);
              panel.Controls.Add(pilates);

              Button kardio = new Button();
              kardio.Text = "Кардио";
              kardio.Click += new EventHandler(this.Kardio);
              panel.Controls.Add(kardio);

            Button izlez = new Button();
            izlez.Text = "Излез";
            izlez.Width = 200;
            izlez.Height = 50;
            izlez.ForeColor = Color.White;
            izlez.Font = new Font("Calibri", 20);
            izlez.Location = new Point(0, 200);
            panel.Controls.Add(izlez);

            
           
        }
        public void members_Click(object sender, EventArgs e)
        {

        }
        public void novChlen(object sender, EventArgs e)
        {
        }
        public void IzmeniChlen(object sender, EventArgs e)
        {

        }
        public void SiteChlen(object sender, EventArgs e)
        {

        }

        public void novVrab(object sender, EventArgs e)
        {
        }
        public void IzmeniVrab(object sender, EventArgs e)
        {

        }
        public void SiteVrab(object sender, EventArgs e)
        {

        }

        public void CelaOprema(object sender, EventArgs e)
        {
        }
        public void DodajNova(object sender, EventArgs e)
        {

        }
        public void Izbrishi(object sender, EventArgs e)
        {

        }

        public void Sitetreninzi(object sender, EventArgs e)
        {
        }
        public void Aerobik(object sender, EventArgs e)
        {

        }
        public void HIIT(object sender, EventArgs e)
        {

        }
        public void Joga(object sender, EventArgs e)
        {
        }
        public void Pilates(object sender, EventArgs e)
        {

        }
        public void Kardio(object sender, EventArgs e)
        {

        }
    }
}
