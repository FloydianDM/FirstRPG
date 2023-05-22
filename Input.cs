namespace FirstRPG;

public class Input
{
    private int _hitPoint;
    private int _gold;
    private string _difficulty;
    private Barbarian _barbarian;
    private Rogue _rogue;
    private Mage _mage;
    private Imperial _imperial;
    private Nord _nord;
    private Black _black;
    protected CharacterActions Character = new CharacterActions();
    private bool _menuCheck = true;

    public void SetDifficulty()
    {
        while (_menuCheck)
        {
            Console.WriteLine("---Difficulty Setting---");
            Console.WriteLine("Select a difficulty:");
            Console.WriteLine("Press '1' for 'Easy'");
            Console.WriteLine("Press '2' for 'Medium'");
            Console.WriteLine("Press '3' for 'Hard'");
            Console.WriteLine("------------------------");
            int difficultyId = Convert.ToInt32(Console.ReadLine());

            switch (difficultyId)
            {
                case 1:
                    _hitPoint = 30;
                    _gold = 50;
                    _difficulty = "easy";
                    _menuCheck = false;
                    break;
                case 2:
                    _hitPoint = 25;
                    _gold = 40;
                    _difficulty = "medium";
                    _menuCheck = false;
                    break;
                case 3:
                    _hitPoint = 20;
                    _gold = 30;
                    _difficulty = "hard";
                    _menuCheck = false;
                    break;
            }
        }
        
    }
    public void ClassBuild()
    {
        while (!_menuCheck)
        {
            Console.WriteLine("---Class Selection---");
            Console.WriteLine("Select a class: ");
            Console.WriteLine("press '1' for Barbarian");
            Console.WriteLine("press '2' for Rogue");
            Console.WriteLine("press '3' for Mage");
            Console.WriteLine("---------------------");
            int classId = Convert.ToInt32(Console.ReadLine());
        
            switch (classId)
            {
                case 1:
                    var barbarian = new Barbarian();
                    _barbarian = barbarian;
                    Character.BarbarianSync(_barbarian);
                    _menuCheck = true;
                    break;
                case 2:
                    var rogue = new Rogue();
                    _rogue = rogue;
                    Character.RogueSync(_rogue);
                    _menuCheck = true;
                    break;
                case 3:
                    var mage = new Mage();
                    _mage = mage;
                    Character.MageSync(_mage);
                    _menuCheck = true;
                    break;
            }
        }
    }

    public void RaceBuild()
    {
        while (_menuCheck)
        {
            Console.WriteLine("---Race Selection---");
            Console.WriteLine("Select a race: ");
            Console.WriteLine("press '1' for Imperial");
            Console.WriteLine("press '2' for Nord");
            Console.WriteLine("press '3' for Black");
            Console.WriteLine("---------------------");
            int raceId = Convert.ToInt32(Console.ReadLine());
        
            switch (raceId)
            {
                case 1:
                    var imperial = new Imperial();
                    _imperial = imperial;
                    Character.ImperialSync(_imperial);
                    _menuCheck = false;
                    break;
                case 2:
                    var nord = new Nord();
                    _nord = nord;
                    Character.NordSync(_nord);
                    _menuCheck = false;
                    break;
                case 3:
                    var black = new Black();
                    _black = black;
                    Character.BlackSync(_black);
                    _menuCheck = false;
                    break;
            }
        }
    }

    public void CharacterBuild()
    {
        Console.WriteLine("Character Build is ready!");
        Character.SetHitPointGold(_hitPoint, _gold, _difficulty);
        Character.TotalSpecs();
    }
}