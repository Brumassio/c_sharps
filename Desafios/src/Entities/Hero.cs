namespace Desafios.src.Entities
{
    public abstract class Hero //uma classe abstrata serve para ser a base de outras classes!!!!
    {
        public Hero(string Name, int Level, string HeroType, int HP,int MP, int Speed)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
            this.Speed = Speed;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " " + "Atacou com a sua espada";
        }
        public string ConsultHP()
        {
            return "A vida atual de " + this.Name + " é "+ this.HP;
        }

        public string ConsultMP()
        {
            return "A Mana atual de " + this.Name + " é "+ this.MP;
        }
        public string ConsultSPEED()
        {
            return "A Velocidade de " + this.Name + " é "+ this.Speed;
        }

    }
}