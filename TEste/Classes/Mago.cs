namespace TEste.Classes
{
    class Mago : Classe
    {
        public override string Name { get; set; } = "Mago";       
        public override int ModMana { get; set; } = 5;
        public override string Vantagens { get; set; } = "Magia Arcana";

        public Mago()
        {
        }
        public Mago(string name, int modForça, int modHabilidade, int modVida, int modMana) : base(name, modForça, modHabilidade, modVida, modMana)
        {

        }

    }
}

