using TEste.Classes;
using TEste.Raças;

namespace TEste.FichaPersonagem
{
    public class Player
    {
        public Dados Dados = new Dados();        
        public int Força { get; set; }
        public int Habilidade { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public string Vantagens { get; set; }
        public Raça Raças { get; set; } 
        public Classe Classes { get; set; } 

        public Player()
        {
        }
        public Player(Raça raça, Classe classe)
        {
            Raças = raça;
            Classes = classe;

            Força = (raça.Força + classe.ModForça);
            Habilidade = (raça.Habilidade + classe.ModHabilidade);
            Vida = (raça.Vida + classe.ModVida);
            Mana = (raça.Mana + classe.ModMana);
            Vantagens = classe.Vantagens;
        }

        // Função Ataque
        public int Ataque()
        {            
            if (Classes.Name == "Assassino")
            {
                int dano = Dados.Dices() + Habilidade;
                int danocrit = dano + Força;
                if (dano == (6 + Habilidade))
                {
                    return danocrit;
                }
                else
                {
                    return dano;
                }
            }            
            else
            {
                int dano = Dados.Dices() + Força;
                int danocrit = dano + Habilidade;
                if (dano == (6 + Força))
                {
                    return danocrit;
                }
                else
                {
                    return dano;
                }
            }
        }       
        //Status por ToString
        public virtual string ToString()
        {
            return $"Raça: {Raças.Name}\n"
                 + $"Classe: {Classes.Name}\n"
                 + "---------STATUS--------- \n"
                 + $" Força: {Força} \n"
                 + $" Habilidade: {Habilidade}  \n"
                 + $" Vida: {Vida} \n"
                 + $" Mana: {Mana}  \n"
                 + $" Vantagens:{Vantagens}";

        }

    }
}
