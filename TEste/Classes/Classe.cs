using System;
namespace TEste.Classes
{
    public class Classe
    {
        public virtual string Name { get; set; }
        public virtual int ModForça { get; set; }
        public virtual int ModHabilidade { get; set; }
        public virtual int ModVida { get; set; }
        public virtual int ModMana { get; set; }
        public virtual string Vantagens { get; set; }
        public Classe()
        {
        }

        public Classe(string name, int modForça, int modHabilidade, int modVida, int modMana)
        {
            Name = name;
            ModForça = modForça;
            ModHabilidade = modHabilidade;
            ModVida = modVida;
            ModMana = modMana;
        }

        public virtual string ToString()
        {
            return ($">| {Name} \n"              
              + $" Modificador de Força: {ModForça} \n"
              + $" Modificador de Habilidade: {ModHabilidade} \n"
              + $" Modificador de Vida: {ModVida} \n"
              + $" Modificador de Mana: {ModMana} \n"
              + $" Vantagens: {Vantagens}");
        }

    }
}
