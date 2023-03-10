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
    public partial class ShowClasses : Form
    {     
        public ShowRaces2 showRaces2 { get; set; } = new ShowRaces2();       
        private Button bt { get; set; } = new Button();        
        public ShowClasses()
        {
            InitializeComponent();

        }
        private void ShowNPass()
        {
            showRaces2.Show();
            this.Close();
        }

        private void btonAssassino_Click(object sender, EventArgs e)
        {
            
            bt = sender as Button;
            bt.Text = btonAssassino.Text;
            if (bt.Text == btonAssassino.Text)
            {
                showRaces2.showClasses2.painelCombate.classes1 = new Assassino();
            }
            ShowNPass();
        }

        private void btonGuerreiro_Click(object sender, EventArgs e)
        {            
            bt = sender as Button;
            bt.Text = btonGuerreiro.Text;
            if (bt.Text == btonGuerreiro.Text)
            {
                showRaces2.showClasses2.painelCombate.classes1 = new Guerreiro();
            }
            ShowNPass();
        }

        private void btonMago_Click(object sender, EventArgs e)
        {            
            bt = sender as Button;
            bt.Text = btonMago.Text;
            if (bt.Text == btonMago.Text)
            {
                showRaces2.showClasses2.painelCombate.classes1 = new Mago();

            }
            ShowNPass();
        }

        private void btonClérigo_Click(object sender, EventArgs e)
        {            
            bt = sender as Button;
            bt.Text = btonClérigo.Text;
            if (bt.Text == btonClérigo.Text)
            {
                showRaces2.showClasses2.painelCombate.classes1 = new Clérigo();

            }
            ShowNPass();
        }

    }
}
