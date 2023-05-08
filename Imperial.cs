namespace FirstRPG;

public class Imperial : Race
{
    private int _raceStr = 0;
    private int _raceDex = 1;
    private int _raceInt = 2;

    public Imperial(int str, int dex, int intel)
    {
        Console.WriteLine("Imperial!");
        
        _raceStr = str;
        _raceDex = dex;
        _raceInt = intel;
    }
}