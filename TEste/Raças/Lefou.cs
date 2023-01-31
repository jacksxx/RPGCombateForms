namespace TEste.Raças
{
    class Lefou : Raça
    {
        public override string Name { get; set; } = "Lefou";
        public override int Força { get; set; } = 7;
        public override int Habilidade { get; set; } = 7;
        public override int Vida { get; set; } = 10;
        public override int Mana { get; set; } = 5;

        public Lefou()
        {
        }
        public Lefou(string name, int força, int habilidade, int vida, int mana) : base(name, força, habilidade, vida, mana)
        {
        }
    }
}
