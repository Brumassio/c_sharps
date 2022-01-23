namespace Desafios.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP,int MP, int Speed) : base(Name, Level, HeroType, HP, MP, Speed)
        {
        }

        public override string Attack()
        {
            return "O Ninja " + this.Name + "atacou com sua katana !";
        }
        public  string Attack(int EscolhaAtaque)
        {
            if(EscolhaAtaque == 0)
            {
                return "O Ninja " + this.Name + " escolheu e atacou com seus punhos !";
            }
            else if(EscolhaAtaque == 1)
            {
                return "O Ninja " + this.Name + " escolheu e atacou com shurikens explosivas !";
            }
            else
            {
                return "O Ninja " + this.Name+ " escolheu e atacou com sua katana !";
            }
        }
    }
}