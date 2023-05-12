namespace FirstRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Input();
            input.SetDifficulty();
            input.ClassBuild();
            input.RaceBuild();
            input.CharacterBuild();
            
            input.EventTransfer();
        }
    }
}