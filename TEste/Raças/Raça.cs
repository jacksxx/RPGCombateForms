using System;


namespace TEste.Raças
{
    public class Raça
    {
        public virtual string Name { get; set; }
        public virtual int Força { get; set; }
        public virtual int Habilidade { get; set; }
        public virtual int Vida { get; set; }
        public virtual int Mana { get; set; }     

        public Raça()
        {
        }        
        public Raça(string name, int força, int habilidade, int vida, int mana)
        {
            Name = name;
            Força = força;
            Habilidade = habilidade;
            Vida = vida;
            Mana = mana;
        }
      


        public virtual string ToString()
        {

            return ($">| {Name} \n"
              + $" Força: {Força} |\n"
              + $" Habilidade: {Habilidade} |\n"
              + $" Vida: {Vida} |\n"
              + $" Mana: {Mana} |\n"
              + "\n");
        }
    }
}

