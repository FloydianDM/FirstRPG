namespace FirstRPG;

public class Barbarian : Class
{
    private int _str = 20;
    private int _dex = 15;
    private int _intel = 5;
    public Barbarian()
    {
        Console.WriteLine("Barbarian!");
        ClassStr = _str;
        ClassDex = _dex;
        ClassInt = _intel;
    }
}
