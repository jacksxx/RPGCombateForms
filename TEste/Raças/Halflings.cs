namespace TEste.Raças
{
    class Halflings : Raça
    {
        public override string Name { get; set; } = "Halfling";
        public override int Força { get; set; } = 5;
        public override int Habilidade { get; set; } = 9;
        public override int Vida { get; set; } = 5;
        public override int Mana { get; set; } = 10;

        public Halflings()
        {
        }
        public Halflings(string name, int força, int habilidade, int vida, int mana) : base(name, força, habilidade, vida, mana)
        {
        }
    }
}
