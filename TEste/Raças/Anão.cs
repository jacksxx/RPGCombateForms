
namespace TEste.Raças
{
    class Anão : Raça
    {
        public override string Name { get; set; } = "Anão";
        public override int Força { get; set; } = 7;
        public override int Habilidade { get; set; } = 6;
        public override int Vida { get; set; } = 15;
        public override int Mana { get; set; } = 5;


        public Anão()
        {

        }
        public Anão(string name, int força, int habilidade, int vida, int mana) : base(name, força, habilidade, vida, mana)
        {
        }

    }
}
