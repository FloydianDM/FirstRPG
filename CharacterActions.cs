namespace FirstRPG;

public class CharacterActions : Character
{
    public CharacterActions()
    {
        
    }
    
    private void CheckHealth()
    {
        if (HitPoint <= 0)
        {
            Console.WriteLine("Game Over!");
            Environment.Exit(0);
        }
    }
    
    public void SetDrink()
    {
        Console.WriteLine("+++Select a Drink+++");
        Console.WriteLine("Write '1' for Beer");
        Console.WriteLine("Write '2' for Wine");
        Console.WriteLine("Write '3' for Ottoman Sherbet");
        Console.WriteLine("++++++++++++++++++++");
        var drinkId = Convert.ToInt32(Console.ReadLine());

        switch (drinkId)
        {
            case 1:
                Console.WriteLine("Drinking a glass of tasty, bitter and herbal ale...");
                Gold --;
                HitPoint += 5;
                Console.WriteLine($"Current gold: {Gold} Current HP: {HitPoint}");
                break;
            case 2:
                Console.WriteLine("Drinking a jar of full bodied red wine, feeling like a noble prick...");
                Gold -= 5;
                HitPoint += 15;
                Console.WriteLine($"Current gold: {Gold} Current HP: {HitPoint}");
                break;
            case 3:
                Console.WriteLine("Game over vahhabi köpeği!");
                HitPoint = 0;
                Console.WriteLine($"Current gold: {Gold} Current HP: {HitPoint}");
                break;
        }
        
        Console.WriteLine("Current character stats: ");
        Console.WriteLine($"Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}");
        
        CheckHealth();
    }

    public int SetFight (int encounterStrength)
    {
        Console.WriteLine($"Fight is started! Encounter Strength: {encounterStrength}");
        
        if (encounterStrength > Strength + 5)
        {
            HitPoint -= 5;
            Console.WriteLine($"+++Remained HP: {HitPoint}+++");
        }

        else if (Strength + 5 > Strength && encounterStrength > Strength)
        {
            HitPoint--;
            Console.WriteLine($"+++Remained HP: {HitPoint}+++");
        }
        
        CheckHealth();
        
        Console.WriteLine("Current character stats: ");
        Console.WriteLine($"Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}");

        return HitPoint;
    }

    public void SetTraining()
    {
        Console.WriteLine($"Current HP: {HitPoint}");
        Console.WriteLine("+++Select Training: +++");
        Console.WriteLine("Press '1' for Full Body Workout");
        Console.WriteLine("Press '2' for Technical Exercises");
        Console.WriteLine("Press '3' for Reading");
        Console.WriteLine("+++++++++++++++++++++++");
        int trainingId = Convert.ToInt32(Console.ReadLine());

        switch (trainingId)
        {
            case 1 :
                Strength += 3;
                Console.WriteLine($"Strength: {Strength}");
                break;
            case 2 :
                Dexterity += 3;
                Console.WriteLine($"Dexterity: {Dexterity}");
                break;
            case 3 :
                Intelligence += 3;
                Console.WriteLine($"Intelligence: {Intelligence}");
                break;
        }

        Console.WriteLine("Current character stats: ");
        Console.WriteLine($"Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}");
    }

    public void SetReplenish()
    {
        while (Gold >= 5)
        {
            Gold -= 5;
        
            switch (Difficulty)
            {
                case "easy" :
                    if (HitPoint > 30)
                        HitPoint += 5;
                    else
                        HitPoint = 30;
                    break;
                case "medium" :
                    if (HitPoint > 25)
                        HitPoint += 5;
                    else
                        HitPoint = 25;
                    break;
                case "hard" :
                    if (HitPoint > 20)
                        HitPoint += 5;
                    else
                        HitPoint = 20;
                    break;
            }

            Console.WriteLine("Health is replenished!");
            Console.WriteLine($"HP: {HitPoint}");

            return;
        }

        Console.Write("Your gold is inadequate! Do you want to work at Inn to gain enough money to stay one night? (y/n)");
        string work = Console.ReadLine();

        switch (work)
        {
            case "y" :
                SetWork();
                Console.WriteLine($"Strength: {Strength}");
                break;
            case "n" :
                Console.WriteLine("Then let's do some training to spend some time.");
                SetTraining();
                break;
        }
    }

    private void SetWork()
    {
        if (Strength > 1)
        {
            Gold += 5;
            Console.WriteLine("You earn enough gold to stay one night!");
            SetReplenish(); 
            Strength--;
            return;
        }

        Console.WriteLine("Do not have any strength to do some work, let's train then.");
        SetTraining();
    }
}