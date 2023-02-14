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
using System.Reflection.Emit;

namespace TEste
{

    public partial class PainelCombate : Form
    {       
        public Raça raças1 { get; set; } = new Raça();
        public Raça raças2 { get; set; } = new Raça();
        public Classe classes1 { get; set; } = new Classe();
        public Classe classes2 { get; set; } = new Classe();
        public Player player1 { get; set; } = new Player();
        public Player player2 { get; set; } = new Player();
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
            player1 = new Player(raças1, classes1);
            player2 = new Player(raças2, classes2);
            label1_Load();
            label2_Load();
        }
        private void label1_Load()
        {
            label1.Text = " PLAYER 1 \n" + player1.ToString();
        }
        private void label2_Load()
        {
            label2.Text = " PLAYER 2 \n" + player2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2 = (Button)sender;
            button2.Enabled = false;
            player1.Ataque();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3 = (Button)sender;
            button3.Enabled = false;
            player2.Ataque();
        }

        private void label3_Load()
        {
            label3.ResetText();
            if ((button2.Enabled == false) && (button3.Enabled == false))
            {
                int atkP1 = player1.Ataque();
                int atkP2 = player2.Ataque();
                if (atkP1 > atkP2)
                {
                    int dnvida = atkP1 - atkP2;
                    player2.Vida = player2.Vida - dnvida;
                    label3.Text = "PLAYER 1 ATACOU ";
                    if (atkP1 >= 19)
                    {
                        label3.Text += "- DANO CRITICO";
                    }
                }
                else if (atkP2 > atkP1)
                {
                    int dnvida = atkP2 - atkP1;
                    player1.Vida = player1.Vida - dnvida;
                    label3.Text = "PLAYER 2 ATACOU ";
                    if (atkP2 >= 19)
                    {
                        label3.Text += "- DANO CRITICO";
                    }
                }
                else
                {
                    label3.Text = " EMPATE ";
                }
            }
        }        
    }
}
