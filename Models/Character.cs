namespace rolePlayingGame.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name {get; set;} = "Clark Kent";
        public int Health { get; set; } = 100;
        public int Strength {get; set;} = 10;
        public int Defense {get; set;} = 10;
        public int Intelligence {get; set;} = 10;
        public RpgClass Class {get; set;} = RpgClass.Assassin;


    }
}