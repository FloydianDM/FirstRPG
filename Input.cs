namespace FirstRPG;

public class Input
{
    private int _hitPoint;
    private int _gold;
    private Barbarian _barbarian;
    private Rogue _rogue;
    private Mage _mage;
    private Imperial _imperial;
    private Nord _nord;
    private Black _black;
    public CharacterActions Character = new CharacterActions();

    public void SetDifficulty()
    {
        Console.WriteLine("---Difficulty Setting---");
        Console.WriteLine("Select a difficulty:");
        Console.WriteLine("Press '1' for 'Easy'");
        Console.WriteLine("Press '2' for 'Medium'");
        Console.WriteLine("Press '3' for 'Hard'");
        Console.WriteLine("------------------------");
        int difficultyID = Convert.ToInt32(Console.ReadLine());

        switch (difficultyID)
        {
            case 1:
                _hitPoint = 30;
                _gold = 50;
                break;
            case 2:
                _hitPoint = 25;
                _gold = 40;
                break;
            case 3:
                _hitPoint = 20;
                _gold = 30;
                break;
        }
    }
    public void ClassBuild()
    {
        Console.WriteLine("---Class Selection---");
        Console.WriteLine("Select a class: ");
        Console.WriteLine("press '1' for Barbarian");
        Console.WriteLine("press '2' for Rogue");
        Console.WriteLine("press '3' for Mage");
        Console.WriteLine("---------------------");
        int classID = Convert.ToInt32(Console.ReadLine());
        
        switch (classID)
        {
            case 1:
                var barbarian = new Barbarian();
                _barbarian = barbarian;
                Character.BarbarianSync(_barbarian);
                break;
            case 2:
                var rogue = new Rogue();
                _rogue = rogue;
                Character.RogueSync(_rogue);
                break;
            case 3:
                var mage = new Mage();
                _mage = mage;
                Character.MageSync(_mage);
                break;
        }
    }

    public void RaceBuild()
    {
        Console.WriteLine("---Race Selection---");
        Console.WriteLine("Select a race: ");
        Console.WriteLine("press '1' for Imperial");
        Console.WriteLine("press '2' for Nord");
        Console.WriteLine("press '3' for Black");
        Console.WriteLine("---------------------");
        int raceID = Convert.ToInt32(Console.ReadLine());
        
        switch (raceID)
        {
            case 1:
                var imperial = new Imperial();
                _imperial = imperial;
                Character.ImperialSync(_imperial);
                break;
            case 2:
                var nord = new Nord();
                _nord = nord;
                Character.NordSync(_nord);
                break;
            case 3:
                var black = new Black();
                _black = black;
                Character.BlackSync(_black);
                break;
        }
    }

    public void CharacterBuild()
    {
        Console.WriteLine("Character Build is ready!");
        Character.SetHitPointGold(_hitPoint, _gold);
        Character.TotalSpecs();
    }

    public void EventTransfer()
    {
        Character.SetDrink();
        Character.SetFight(10);
    }
}