namespace FirstRPG;

public class Rogue : Class
{
    public Rogue(int str, int dex, int intel)
    {
        Console.WriteLine("Rogue!");
        ClassStr = str;
        ClassDex = dex;
        ClassInt = intel;
    }
    
}