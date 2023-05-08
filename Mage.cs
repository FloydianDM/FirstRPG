namespace FirstRPG;

public class Mage : Class
{
    public Mage(int str, int dex, int intel)
    {
        Console.WriteLine("Mage!");
        ClassStr = str;
        ClassDex = dex;
        ClassInt = intel;
    }
}