namespace TEste.Raças
{
    class Elfo : Raça
    {
        public override string Name { get; set; } = "Elfo";
        public override int Força { get; set; } = 6;
        public override int Habilidade { get; set; } = 7;
        public override int Vida { get; set; } = 5;
        public override int Mana { get; set; } = 15;

        public Elfo()
        {
        }
        public Elfo(string name, int força, int habilidade, int vida, int mana) : base(name, força, habilidade, vida, mana)
        {
        }
    }
}
