using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEste.Raças;
using TEste.Classes;
using TEste.FichaPersonagem;

namespace TEste
{

    public partial class PainelCombate : Form
    {
        public Raça raças { get; set; } = new Raça();
        public Classe classes { get; set; } = new Classe();
        public Player player1 { get; set; } = new Player();
        public PainelCombate()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            player1 = new Player(raças, classes);
            label1_Load();
            label2_Load();

        }
        private void label1_Load()
        {
            label1.Text = raças.ToString();
        }
        private void label2_Load()
        {
            label2.Text = " PLAYER 2 \n" + player1.ToString();
        }        
    }
}
