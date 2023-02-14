using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEste.Classes;
using TEste.Raças;

namespace TEste
{
    public partial class ShowRaces2 : Form
    {
        public ShowClasses2 showClasses2 = new ShowClasses2();
        private Button bts { get; set; } = new Button();

        public ShowRaces2()
        {
            InitializeComponent();
        }
        private void ShowNPass()
        {
            showClasses2.Show();
            this.Close();
        }


        private void btonHuman_Click_1(object sender, EventArgs e)
        {
            bts = sender as Button;
            bts.Text = btonHuman.Text;
            if (bts.Text == btonHuman.Text)
            {
                showClasses2.painelCombate.raças2 = new Humano();
            }
            ShowNPass();
        }

        private void btonAnão_Click_1(object sender, EventArgs e)
        {           
            bts = sender as Button;
            bts.Text = btonAnão.Text;
            if (bts.Text == btonAnão.Text)
            {
                showClasses2.painelCombate.raças2 = new Anão();

            }
            ShowNPass();
        }

        private void btonHalfling_Click_1(object sender, EventArgs e)
        {
            bts = sender as Button;
            bts.Text = btonHalfling.Text;
            if (bts.Text == btonHalfling.Text)
            {
                showClasses2.painelCombate.raças2 = new Halflings();

            }
            ShowNPass();
        }

        private void btonElfo_Click_1(object sender, EventArgs e)
        {
            bts = sender as Button;
            bts.Text = btonElfo.Text;
            if (bts.Text == btonElfo.Text)
            {
                showClasses2.painelCombate.raças2 = new Elfo();

            }
            ShowNPass();
        }

        private void btonGoblin_Click_1(object sender, EventArgs e)
        {
            bts = sender as Button;
            bts.Text = btonGoblin.Text;
            if (bts.Text == btonGoblin.Text)
            {
                showClasses2.painelCombate.raças2 = new Goblin();

            }
            ShowNPass();
        }

        private void btonLefou_Click_1(object sender, EventArgs e)
        {
            bts = sender as Button;
            bts.Text = btonLefou.Text;
            if (bts.Text == btonLefou.Text)
            {
                showClasses2.painelCombate.raças2 = new Lefou();

            }
            ShowNPass();
        }

        private void btonMinotauro_Click_1(object sender, EventArgs e)
        {
            bts = sender as Button;
            bts.Text = btonMinotauro.Text;
            if (bts.Text == btonMinotauro.Text)
            {
                showClasses2.painelCombate.raças2 = new Minotauro();

            }
            ShowNPass();
        }
    }
}
