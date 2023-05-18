namespace FirstRPG;

public class Nord : Race
{
    private int _str = 15;
    private int _dex = 5;
    private int _intel = 10;

    public Nord()
    {
        Console.WriteLine("Nord!");
        
        RaceStr = _str;
        RaceDex = _dex;
        RaceInt = _intel;
    }
}