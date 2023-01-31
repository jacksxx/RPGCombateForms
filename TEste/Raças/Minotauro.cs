
namespace TEste.Raças
{
    class Minotauro : Raça
    {
        public override string Name { get; set; } = "Minotauro";
        public override int Força { get; set; } = 8;
        public override int Habilidade { get; set; } = 6;
        public override int Vida { get; set; } = 10;
        public override int Mana { get; set; } = 5;

        public Minotauro()
        {
        }
        public Minotauro(string name, int força, int habilidade, int vida, int mana) : base(name, força, habilidade, vida, mana)
        {
        }
    }
}
