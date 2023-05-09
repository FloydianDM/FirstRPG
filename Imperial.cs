namespace FirstRPG;

public class Imperial : Race
{
    private int _str = 0;
    private int _dex = 1;
    private int _intel = 2;

    public Imperial()
    {
        Console.WriteLine("Imperial!");
        
        RaceStr = _str;
        RaceDex = _dex;
        RaceInt = _intel;
    }
}