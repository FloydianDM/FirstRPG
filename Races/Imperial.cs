namespace FirstRPG;

public class Imperial : Race
{
    private int _str = 5;
    private int _dex = 10;
    private int _intel = 15;

    public Imperial()
    {
        Console.WriteLine("Imperial!");
        
        RaceStr = _str;
        RaceDex = _dex;
        RaceInt = _intel;
    }
}