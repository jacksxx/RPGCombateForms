namespace TEste.Classes
{
    class Assassino : Classe
    {
        public override string Name { get; set; } = "Assassino";
        public override int ModHabilidade { get; set; } = 2;
        public override string Vantagens { get; set; } = "Ataque Base = Habilidade + Dado";

        public Assassino()
        {
        }
        public Assassino(string name, int modForça, int modHabilidade, int modVida, int modMana) : base(name, modForça, modHabilidade, modVida, modMana)
        {

        }
    }
}
