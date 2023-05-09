namespace FirstRPG;

public class Barbarian : Class
{
    private int _str = 2;
    private int _dex = 1;
    private int _intel = 0;
    public Barbarian()
    {
        Console.WriteLine("Barbarian!");
        ClassStr = _str;
        ClassDex = _dex;
        ClassInt = _intel;
    }
}
