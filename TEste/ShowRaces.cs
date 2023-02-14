using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TEste.Raças;

namespace TEste
{
    public partial class ShowRaces : Form
    {
        private ShowClasses showClasses = new ShowClasses();
        private Button bt { get; set; } = new Button();
        public ShowRaces()
        {
            InitializeComponent();
        }
        private void ShowNPass()
        {
            showClasses.Show();
            this.Close();
        }
        private void btonHumano_Click(object sender, EventArgs e)
        {            
            bt = sender as Button;
            bt.Text = btonHumano.Text;
            if (bt.Text == btonHumano.Text)
            {
                showClasses.showRaces2.showClasses2.painelCombate.raças1 = new Humano();
            }
            ShowNPass();
        }
        private void btonElfo_Click(object sender, EventArgs e)
        {            
            bt = sender as Button;
            bt.Text = btonElfo.Text;
            if (bt.Text == btonElfo.Text)
            {
                showClasses.showRaces2.showClasses2.painelCombate.raças1 = new Elfo();

            }
            ShowNPass();
        }
        private void btonAnão_Click(object sender, EventArgs e)
        {            
            bt = sender as Button;
            bt.Text = btonAnão.Text;
            if (bt.Text == btonAnão.Text)
            {
                showClasses.showRaces2.showClasses2.painelCombate.raças1 = new Anão();

            }
            ShowNPass();
        }
        private void btonGoblin_Click(object sender, EventArgs e)
        {            
            bt = sender as Button;
            bt.Text = btonGoblin.Text;
            if (bt.Text == btonGoblin.Text)
            {
                showClasses.showRaces2.showClasses2.painelCombate.raças1 = new Goblin();

            }
            ShowNPass();
        }
        private void btonHalfling_Click(object sender, EventArgs e)
        {            
            bt = sender as Button;
            bt.Text = btonHalfling.Text;
            if (bt.Text == btonHalfling.Text)
            {
                showClasses.showRaces2.showClasses2.painelCombate.raças1 = new Halflings();

            }
            ShowNPass();
        }
        private void btonLefou_Click(object sender, EventArgs e)
        {           
            bt = sender as Button;
            bt.Text = btonLefou.Text;
            if (bt.Text == btonLefou.Text)
            {
                showClasses.showRaces2.showClasses2.painelCombate.raças1 = new Lefou();

            }
            ShowNPass();
        }
        private void btonMinotauro_Click(object sender, EventArgs e)
        {           
            bt = sender as Button;
            bt.Text = btonMinotauro.Text;
            if (bt.Text == btonMinotauro.Text)
            {
                showClasses.showRaces2.showClasses2.painelCombate.raças1 = new Minotauro();

            }
            ShowNPass();
        }

    }
}
