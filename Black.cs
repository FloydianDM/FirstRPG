namespace FirstRPG;

public class Black : Race
{
    private int _raceStr;
    private int _raceDex;
    private int _raceInt;

    public Black(int str, int dex, int intel)
    {
        Console.WriteLine("Black!");
        
        _raceStr = str;
        _raceDex = dex;
        _raceInt = intel;

    }
}