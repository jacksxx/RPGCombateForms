using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEste.Classes
{
    class Clérigo : Classe
    {
        public override string Name { get; set; } = "Clérigo";
        public override int ModMana { get; set; } = 5;
        public override string Vantagens { get; set; } = "Magia Sagrada";

        public Clérigo()
        {
        }
        public Clérigo(string name, int modForça, int modHabilidade, int modVida, int modMana) : base(name, modForça, modHabilidade, modVida, modMana)
        {

        }
    }
}
