using System;

namespace TEste
{
     public class Dados
    {
        private Random Dado = new Random();
        public Dados()
        {
        }
        public int Dices()
        {
            int dice = Dado.Next(1, 7);
            return dice;
        }

    }
}
