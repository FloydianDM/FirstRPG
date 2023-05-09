namespace FirstRPG;

public class Character
{
    protected int HitPoint;
    protected int Gold;
    private int _charClassStr;
    private int _charClassDex;
    private int _charClassInt;
    private int _charRaceStr;
    private int _charRaceDex;
    private int _charRaceInt;
    protected int Strength;
    protected int Dexterity;
    protected int Intelligence;

    public Character()
    {
    }
    
    public void SetHitPointGold(int hitPoint, int gold)
    {
        HitPoint = hitPoint;
        Gold = gold;
    }

    public void Sync()
    {
        var charClass = new Class();
        var charRace = new Race();

        _charClassStr = charClass.ClassStr;
        _charClassDex = charClass.ClassDex;
        _charClassInt = charClass.ClassInt;

        _charRaceStr = charRace.RaceStr;
        _charRaceDex = charRace.RaceDex;
        _charRaceInt = charRace.RaceInt;
    }

    public void TotalSpecs()
    {
        Strength = _charClassStr + _charRaceStr;
        Dexterity = _charClassDex + _charRaceDex;
        Intelligence = _charClassInt + _charRaceInt;
    }
}