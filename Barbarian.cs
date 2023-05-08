namespace FirstRPG;

public class Barbarian : Class
{
    public Barbarian(int str, int dex, int intel)
    {
        Console.WriteLine("Barbarian!");
        ClassStr = str;
        ClassDex = dex;
        ClassInt = intel;
    }
}
