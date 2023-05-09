namespace FirstRPG;

public class Mage : Class
{
    private int _str = 0;
    private int _dex = 1;
    private int _intel = 2;
    public Mage()
    {
        Console.WriteLine("Mage!");
        ClassStr = _str;
        ClassDex = _dex;
        ClassInt = _intel;
    }
}