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

namespace TEste
{
    public partial class ShowClasses2 : Form
    {        
        public PainelCombate painelCombate { get; set; } = new PainelCombate();
        private Button bt { get; set; } = new Button();
        public ShowClasses2()
        {
            InitializeComponent();
        }
        private void ShowNPass()
        {

            painelCombate.Show();
            this.Close();


        }    
        private void btonAssassino_Click_1(object sender, EventArgs e)
        {
            bt = sender as Button;
            bt.Text = btonAssassino.Text;
            if (bt.Text == btonAssassino.Text)
            {
                painelCombate.classes2 = new Assassino();
            }
            ShowNPass();
        }
        private void btonGuerreiro_Click_1(object sender, EventArgs e)
        {
            bt = sender as Button;
            bt.Text = btonGuerreiro.Text;
            if (bt.Text == btonGuerreiro.Text)
            {
                painelCombate.classes2 = new Guerreiro();
            }
            ShowNPass();
        }
        private void btonMago_Click_1(object sender, EventArgs e)
        {
            bt = sender as Button;
            bt.Text = btonMago.Text;
            if (bt.Text == btonMago.Text)
            {
                painelCombate.classes2 = new Mago();

            }
            ShowNPass();
        }
        private void btonClérigo_Click_1(object sender, EventArgs e)
        {
            bt = sender as Button;
            bt.Text = btonClérigo.Text;
            if (bt.Text == btonClérigo.Text)
            {
                painelCombate.classes2 = new Clérigo();

            }
            ShowNPass();
        }
    }
}
