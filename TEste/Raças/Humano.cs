namespace TEste.Raças
{
    public class Humano : Raça
    {
        public override string Name { get; set; } = "HUMANO";
        public override int Força { get; set; } = 6;
        public override int Habilidade { get; set; } = 7;
        public override int Vida { get; set; } = 10;
        public override int Mana { get; set; } = 10;


        public Humano()
        {

        }
        public Humano(string name, int força, int habilidade, int vida, int mana) : base(name, força, habilidade, vida, mana)
        {
        }
    }
}
