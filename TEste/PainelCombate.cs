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
        public Combate combate { get; set; } = new Combate();
        public Raça raças1 { get; set; } = new Raça();
        public Raça raças2 { get; set; } = new Raça();
        public Classe classes1 { get; set; } = new Classe();
        public Classe classes2 { get; set; } = new Classe();
        public Player player1 { get; set; } = new Player();
        public Player player2 { get; set; } = new Player();
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
            this.player1 = new Player(raças1, classes1);
            this.player2 = new Player(raças2, classes2);
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
            label3_Load();
        }
        private void label3_Load()
        {
            label3.ResetText();
            atk1 = player1.Ataque();
            atk2 = player1.Ataque();
            combate.Combat(player1, player2, atk1, atk2);
            combatxt();

        }
        private void endgame()
        {
            button1.Enabled = true;
            if (player1.Vida <= 0)
            {
                label3.ResetText();
                label3.Text = "Player 1 Ataque: " + atk1 + "  - Player 2 Ataque: " + atk2 + "\n";
                label3.Text += "\n Dano:  " + (atk2 - atk1) + "\n";
                label3.Text += "******PLAYER 2 VENCEDOR*****";
                button2.Enabled = false;
            }
            else if (player2.Vida <= 0)
            {
                label3.ResetText();
                label3.Text = "Player 1 Ataque: " + atk1 + "  - Player 2 Ataque: " + atk2 + "\n";
                label3.Text += "\n Dano:  " + (atk1 - atk2) + "\n";
                label3.Text += "******PLAYER 1 VENCEDOR*****";
                button2.Enabled = false;
            }
        }
        private void combatxt()
        {
            if (atk1 > atk2)
            {
                label3.Text = "Player 1 Ataque: " + atk1 + "  - Player 2 Ataque: " + atk2 + "\n";
                label3.Text += "\n Dano:  " + (atk1 - atk2) + "\n";
                label3.Text += "\n PLAYER 1 ATACOU ";
                if (atk1 >= 19)
                {
                    label3.Text += "- DANO CRITICO";
                }
            }
            else if (atk2 > atk1)
            {
                label3.Text = "Player 1 Ataque: " + atk1 + "  - Player 2 Ataque: " + atk2 + "\n";
                label3.Text += "\n Dano:  " + (atk2 - atk1) + "\n";
                label3.Text += "\n PLAYER 2 ATACOU ";
                if (atk2 >= 19)
                {
                    label3.Text += "- DANO CRITICO";
                }
            }
            else
            {
                label3.Text = "Player 1 Ataque: " + atk1 + "  - Player 2 Ataque: " + atk2 + "\n";
                label3.Text += "\n EMPATE ";
            }
            lb1reset();
            lb2reset();
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
