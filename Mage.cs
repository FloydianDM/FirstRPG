namespace FirstRPG;

public class Mage : Class
{
    private int _str = 5;
    private int _dex = 10;
    private int _intel = 25;
    public Mage()
    {
        Console.WriteLine("Mage!");
        ClassStr = _str;
        ClassDex = _dex;
        ClassInt = _intel;
    }
}