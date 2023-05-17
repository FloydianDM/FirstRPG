namespace FirstRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Events();
            input.SetDifficulty();
            input.ClassBuild();
            input.RaceBuild();
            input.CharacterBuild();
            
            input.Bar1();
            input.Village1();
        }
    }
}