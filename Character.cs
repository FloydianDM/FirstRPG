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
    
    public void BarbarianSync(Barbarian barbarian)
    {
        _charClassStr = barbarian.ClassStr;
        _charClassDex = barbarian.ClassDex;
        _charClassInt = barbarian.ClassInt;
    }

    public void RogueSync(Rogue rogue)
    {
        _charClassStr = rogue.ClassStr;
        _charClassDex = rogue.ClassDex;
        _charClassInt = rogue.ClassInt;
    }

    public void MageSync(Mage mage)
    {
        _charClassStr = mage.ClassStr;
        _charClassDex = mage.ClassDex;
        _charClassInt = mage.ClassInt;
    }

    public void ImperialSync(Imperial imperial)
    {
        _charRaceStr = imperial.RaceStr;
        _charRaceDex = imperial.RaceDex;
        _charRaceInt = imperial.RaceInt;
    }

    public void NordSync(Nord nord)
    {
        _charRaceStr = nord.RaceStr;
        _charRaceDex = nord.RaceDex;
        _charRaceInt = nord.RaceInt;
    }

    public void BlackSync(Black black)
    {
        _charRaceStr = black.RaceStr;
        _charRaceDex = black.RaceDex;
        _charRaceInt = black.RaceInt;
    }

    public void TotalSpecs()
    {
        Strength = _charClassStr + _charRaceStr;
        Dexterity = _charClassDex + _charRaceDex;
        Intelligence = _charClassInt + _charRaceInt;
    }
}