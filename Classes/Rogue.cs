namespace FirstRPG;

public class Rogue : Class
{
    private int _str = 10;
    private int _dex = 20;
    private int _intel = 10;
    
    public Rogue()
    {
        Console.WriteLine("Rogue!");
        ClassStr = _str;
        ClassDex = _dex;
        ClassInt = _intel;
    }
    
}