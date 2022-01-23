namespace Desafios.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP,int MP, int Speed) : base(Name, Level, HeroType, HP, MP, Speed)
        {
        }

        public override string Attack()
        {
            return this.Name + " " + "Lançou magia !!!";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " " + "Lançou magia  super efetiva com bonus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " " + "Lançou magia com força fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}