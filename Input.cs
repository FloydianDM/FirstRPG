namespace FirstRPG;

public class Input
{ 
    private int _hitPoint;
    private int _gold;
    
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
                Barbarian charClass1 = new Barbarian();
                break;
            case 2:
                Rogue charClass2 = new Rogue();
                break;
            case 3:
                Mage charClass3 = new Mage();
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
                var charRace1 = new Imperial();
                break;
            case 2:
                var charRace2 = new Nord();
                break;
            case 3:
                var charRace3 = new Black();
                break;
        }
    }

    public void CharacterBuild()
    {
        Console.WriteLine("Character Build is ready!");
        Character character = new Character();
        character.SetHitPointGold(_hitPoint, _gold);
        character.Sync();
        character.TotalSpecs();
    }
}