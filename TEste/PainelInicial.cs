using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEste.FichaPersonagem;

namespace TEste
{
    public partial class PainelInicial : Form
    {
        private ShowRaces showRaces = new ShowRaces();
        public PainelInicial()
        {
            InitializeComponent();
        }
        private void PainelInicial_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            showRaces.Show();
            this.Close();            
        }
    }
}
