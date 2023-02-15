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
        public Player2 player2 { get; set; } = new Player2();      
        public int atk1 { get; set; }
        public int atk2 { get; set; }
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
            label1_Load();
            label2_Load();
        }
        private void label1_Load()
        {
            player1 = new Player(raças1, classes1);
            atk1 = player1.Ataque();
            label1.Text = " PLAYER 1 \n" + player1.ToString();

        }
        private void label2_Load()
        {
            player2 = new Player2(raças2, classes2);
            atk2 = player2.Ataque2();
            label2.Text = " PLAYER 2 \n" + player2.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {            
            label3_Load();
        }
        private void label3_Load()
        {
            label3.ResetText();
            combate(atk1,atk2);
            lb1reset(); lb2reset();
        }
        private void endgame()
        {
            if (player1.Vida <= 0)
            {
                label3.ResetText();
                label3.Text = "******PLAYER 2 VENCEDOR*****";
                button2.Enabled = false;
            }
            else if (player2.Vida <= 0)
            {
                label3.ResetText();
                label3.Text = "******PLAYER 1 VENCEDOR*****";
                button2.Enabled = false;
            }
        }
        private void combate(int atkp1,int atkp2)
        {
            atkp1 = player1.Ataque(); 
            atkp2 = player2.Ataque2();
            int dnvida1 = atkp1 - atkp2; 
            int dnvida2 = atkp2 - atkp1;            

            if ((atkp1 != null) && (atkp2 != null))
            {
                if (atkp1 > atkp2)
                {
                    player2.Vida = player2.Vida - dnvida1;
                    label3.Text = "Player 1 Ataque: " + atkp1 + "  - Player2 Ataque: " + atkp2 + "\n";
                    label3.Text += "\n PLAYER 1 ATACOU ";
                    if (atkp1 >= 19)
                    {
                        label3.Text += "- DANO CRITICO";
                    }
                }
                else if (atkp2 > atkp1)
                {
                    player1.Vida = player1.Vida - dnvida2;
                    label3.Text = "Player 1 Ataque: " + atkp1 + "  - Player2 Ataque: " + atkp2 + "\n";
                    label3.Text += "\n PLAYER 2 ATACOU ";
                    if (atkp2 >= 19)
                    {
                        label3.Text += "- DANO CRITICO";
                    }
                }
                else
                {
                    label3.Text = "Player 1 Ataque: " + atkp1 + "  - Player2 Ataque: " + atkp2 + "\n";
                    label3.Text += "\n EMPATE ";
                }
            }
            endgame();
        }
        private void lb1reset()
        {
            label1.ResetText();
            label1.Text = " PLAYER 1 \n" + player1.ToString();
        }
        private void lb2reset()
        {
            label2.ResetText();
            label2.Text = " PLAYER 2 \n" + player2.ToString();
        }
    }
}
