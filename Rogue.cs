namespace FirstRPG;

public class Rogue : Class
{
    private int _str = 1;
    private int _dex = 1;
    private int _intel = 1;
    
    public Rogue()
    {
        Console.WriteLine("Rogue!");
        ClassStr = _str;
        ClassDex = _dex;
        ClassInt = _intel;
    }
    
}