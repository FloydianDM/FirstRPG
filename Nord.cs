namespace FirstRPG;

public class Nord : Race
{
    private int _raceStr = 1;
    private int _raceDex = 1;
    private int _raceInt = 1;

    public Nord(int str, int dex, int intel)
    {
        Console.WriteLine("Nord!");
        
        _raceStr = str;
        _raceDex = dex;
        _raceInt = intel;
    }
}