namespace FirstRPG;

public class Character
{
    private int _charClassStr;
    private int _charClassDex;
    private int _charClassInt;
    private int _charRaceStr;
    private int _charRaceDex;
    private int _charRaceInt;
    private int _strength;
    private int _dexterity;
    private int _intelligence;

    public Character()
    {
        
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
        _strength = _charClassStr + _charRaceStr;
        _dexterity = _charClassDex + _charRaceDex;
        _intelligence = _charClassInt + _charRaceInt;
    }

}