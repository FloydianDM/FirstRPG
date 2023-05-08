namespace FirstRPG;

public class Input
{
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
                Barbarian charClass1 = new Barbarian(2,1,0);
                break;
            case 2:
                Rogue charClass2 = new Rogue(1,1,1);
                break;
            case 3:
                Mage charClass3 = new Mage(0, 1,2);
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
                var charRace1 = new Imperial(0,1,2);
                break;
            case 2:
                var charRace2 = new Nord(1,1,1);
                break;
            case 3:
                var charRace3 = new Black(2,1,0);
                break;
        }
    }

    public void CharacterBuild()
    {
        Console.WriteLine("Character Built is ready!");
        Character character = new Character();
        character.Sync();
        character.TotalSpecs();
    }
}