namespace FirstRPG;

public class Nord : Race
{
    private int _str = 1;
    private int _dex = 1;
    private int _intel = 1;

    public Nord()
    {
        Console.WriteLine("Nord!");
        
        RaceStr = _str;
        RaceDex = _dex;
        RaceInt = _intel;
    }
}