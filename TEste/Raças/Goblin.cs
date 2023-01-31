namespace TEste.Raças
{
    class Goblin : Raça
    {
        public override string Name { get; set; } = "Goblin";
        public override int Força { get; set; } = 5;
        public override int Habilidade { get; set; } = 9;
        public override int Vida { get; set; } = 10;
        public override int Mana { get; set; } = 5;

        public Goblin()
        {

        }
        public Goblin(string name, int força, int habilidade, int vida, int mana) : base(name, força, habilidade, vida, mana)
        {

        }
    }
}
