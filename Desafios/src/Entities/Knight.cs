namespace Desafios.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP,int MP, int Speed) : base(Name, Level, HeroType, HP, MP, Speed)
        {
        }

        public override string Attack()
        {
            return this.Name + " " + "Atacou com sua espada !!!";
        }

    }
}