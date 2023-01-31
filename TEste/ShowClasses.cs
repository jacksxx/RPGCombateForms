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
        private ShowRaces showRaces { get; set; }
        public PainelCombate painelCombate = new PainelCombate();
        private Button bt { get; set; } = new Button();
        public ShowClasses()
        {
            InitializeComponent();
        }
        private void ShowNPass()
        {
            painelCombate.Show();
            this.Close();
        }

        private void btonAssassino_Click(object sender, EventArgs e)
        {
            bt = sender as Button;
            bt.Text = btonAssassino.Text;
            if (bt.Text == btonAssassino.Text)
            {
                painelCombate.classes = new Assassino();

            }
            ShowNPass();
        }

        private void btonGuerreiro_Click(object sender, EventArgs e)
        {
            bt = sender as Button;
            bt.Text = btonGuerreiro.Text;
            if (bt.Text == btonGuerreiro.Text)
            {
                painelCombate.classes = new Guerreiro();

            }
            ShowNPass();
        }

        private void btonMago_Click(object sender, EventArgs e)
        {
            bt = sender as Button;
            bt.Text = btonMago.Text;
            if (bt.Text == btonMago.Text)
            {
                painelCombate.classes = new Mago();

            }
            ShowNPass();
        }

        private void btonClérigo_Click(object sender, EventArgs e)
        {
            bt = sender as Button;
            bt.Text = btonClérigo.Text;
            if (bt.Text == btonClérigo.Text)
            {
                painelCombate.classes = new Clérigo();

            }
            ShowNPass();
        }

        private void ShowClasses_Load(object sender, EventArgs e)
        {
            showRaces = new ShowRaces();
            showRaces.Hide();
        }
    }
}
