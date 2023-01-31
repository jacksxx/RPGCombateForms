using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEste.Classes
{
    class Guerreiro : Classe
    {
        public override string Name { get; set; } = "Guerreiro";
        public override int ModForça { get; set; } = 1;
        public override int ModVida { get; set; } = 5;
        public override string Vantagens { get; set; } = "Nenhuma";

        public Guerreiro()
        {
        }
        public Guerreiro(string name, int modForça, int modHabilidade, int modVida, int modMana) : base(name, modForça, modHabilidade, modVida, modMana)
        {

        }
    }
}
