namespace Desafios.src
{
    public class Arus
    {
        public Arus(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public string name { get; set; }
        public int level { get; set; }
        public string heroType { get; set; }
    }
}