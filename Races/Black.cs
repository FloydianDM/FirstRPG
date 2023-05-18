namespace FirstRPG;

public class Black : Race
{
    private int _str = 20;
    private int _dex = 10;
    private int _intel = 0;

    public Black()
    {
        Console.WriteLine("Black!");
        
        RaceStr = _str;
        RaceDex = _dex;
        RaceInt = _intel;
    }
}