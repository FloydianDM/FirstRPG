namespace FirstRPG;

public class CharacterActions : Character
{
    private double _armorPrice = 30;
    private double _swordPrice = 25;
    private double _bowPrice = 25;
    private double _bookPrice = 20;
    
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
        bool menuCheck = true;
        while (menuCheck)
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
                    menuCheck = false;
                    break;
                case 2:
                    Console.WriteLine("Drinking a jar of full bodied red wine, feeling like a noble prick...");
                    Gold -= 5;
                    HitPoint += 15;
                    Console.WriteLine($"Current gold: {Gold} Current HP: {HitPoint}");
                    menuCheck = false;
                    break;
                case 3:
                    Console.WriteLine("Game over vahhabi köpeği!");
                    HitPoint = 0;
                    Console.WriteLine($"Current gold: {Gold} Current HP: {HitPoint}");
                    menuCheck = false;
                    break;
            }
        }
        
        Console.WriteLine("Current character stats: ");
        Console.WriteLine($"Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}");
        
        CheckHealth();
    }

    public void SetFight (int encounterStrength, int encounterDexterity, int encounterIntelligence, int encounterVitality)
    {
        bool menuCheck = true;
        while (menuCheck)
        {
            Console.WriteLine($"Fight is started! Encounter Strength: {encounterStrength} Encounter Dexterity: {encounterDexterity} Encounter HitPoint: {encounterVitality}");
            Console.WriteLine("Select a fight method: ");
            Console.WriteLine("Press '1' for close combat (Strength based)");
            Console.WriteLine("Press '2' for archery (Dexterity based)");
            Console.WriteLine("Press '3' for using magic (Intelligence based)");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            int fightId = Convert.ToInt32(Console.ReadLine());
            var random = new Random();

            switch (fightId)
            {
                case 1:
                    while (encounterVitality > 0 && HitPoint > 0)
                    {
                        if (encounterStrength > Strength + 5)
                        {
                            int encounterDamage = 2 * (encounterDexterity + encounterStrength * random.Next(1, 2));
                            HitPoint -= encounterDamage;

                            int characterDamage = Dexterity + Strength * random.Next(2, 4);
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }

                        else if (Strength + 5 > encounterStrength && encounterStrength > Strength)
                        {
                            int encounterDamage = encounterDexterity + encounterStrength * random.Next(1, 3);
                            HitPoint -= encounterDamage;

                            int characterDamage = Dexterity + Strength * random.Next(2, 5);
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }

                        else
                        {
                            int encounterDamage = encounterStrength * random.Next(1, 2);
                            HitPoint -= encounterDamage;

                            int characterDamage = 2 * (Dexterity + Strength * random.Next(1, 2));
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }
                    }

                    CheckHealth();
                    menuCheck = false;
                    break;
                case 2:
                    while (encounterVitality > 0 && HitPoint > 0)
                    {
                        if (encounterDexterity > Dexterity + 5)
                        {
                            int encounterDamage = 2 * (encounterStrength + encounterDexterity * random.Next(1, 2));
                            HitPoint -= encounterDamage;

                            int characterDamage = Strength + Dexterity * random.Next(2, 4);
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }

                        else if (Dexterity + 5 > encounterDexterity && encounterDexterity > Dexterity)
                        {
                            int encounterDamage = encounterStrength + encounterDexterity * random.Next(1, 3);
                            HitPoint -= encounterDamage;

                            int characterDamage = Strength + Dexterity * random.Next(2, 5);
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }

                        else
                        {
                            int encounterDamage = encounterDexterity * random.Next(1, 2);
                            HitPoint -= encounterDamage;

                            int characterDamage = 2 * (Strength + Dexterity * random.Next(1, 2));
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }
                    }

                    CheckHealth();
                    menuCheck = false;
                    break;
                case 3:
                    while (encounterVitality > 0 && HitPoint > 0)
                    {
                        if ((2 * encounterIntelligence + encounterDexterity) > (2 * Intelligence + Dexterity) + 5)
                        {
                            int encounterDamage = 2 * (encounterDexterity + encounterIntelligence * random.Next(1, 2));
                            HitPoint -= encounterDamage;

                            int characterDamage = Dexterity + Intelligence * random.Next(2, 4);
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }

                        else if ((2 * Intelligence + Dexterity) + 5 >
                                 (2 * encounterIntelligence + encounterDexterity) &&
                                 (2 * encounterIntelligence + encounterDexterity) > (2 * Intelligence + Dexterity) + 5)
                        {
                            int encounterDamage = encounterDexterity + encounterIntelligence * random.Next(1, 3);
                            HitPoint -= encounterDamage;

                            int characterDamage = Dexterity + Intelligence * random.Next(2, 5);
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }

                        else
                        {
                            int encounterDamage = encounterIntelligence * random.Next(1, 2);
                            HitPoint -= encounterDamage;

                            int characterDamage = 2 * (Dexterity + Intelligence * random.Next(1, 2));
                            encounterVitality -= characterDamage;

                            Console.WriteLine($"HP: {HitPoint} / Encounter HP: {encounterVitality}");
                        }
                    }

                    CheckHealth();
                    menuCheck = false;
                    break;
            }
        }

        CheckHealth();

        Console.WriteLine("+++++Encounter killed!+++++");
        
        Console.WriteLine("Current character stats: ");
        Console.WriteLine($"Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}");
        
    }

    public void SetTraining()
    {
        bool menuCheck = true;
        while (menuCheck)
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
                    menuCheck = false;
                    break;
                case 2 :
                    Dexterity += 3;
                    Console.WriteLine($"Dexterity: {Dexterity}");
                    menuCheck = false;
                    break;
                case 3 :
                    Intelligence += 3;
                    Console.WriteLine($"Intelligence: {Intelligence}");
                    menuCheck = false;
                    break;
            }
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

        bool menuCheck = true;
        while (menuCheck)
        {
            Console.Write("Your gold is inadequate! Do you want to work at Inn to gain enough money to stay one night? (y/n)");
            string work = Console.ReadLine();

            switch (work)
            {
                case "y" :
                    SetWork();
                    Console.WriteLine($"Strength: {Strength}");
                    menuCheck = false;
                    break;
                case "n" :
                    Console.WriteLine("Then let's do some training to spend some time.");
                    SetTraining();
                    menuCheck = false;
                    break;
            }
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

    public bool SetPurchase()
    {
        while (true)
        {
            Console.WriteLine("+++++ Purchase an Item +++++");
            Console.WriteLine("Press '0' for exit");
            Console.WriteLine("Select an item to purchase: ");
            Console.WriteLine("Press '1' for a new Armor");
            Console.WriteLine($"Price: {_armorPrice}");
            Console.WriteLine("Press '2' for a new Sword");
            Console.WriteLine($"Price: {_swordPrice}");
            Console.WriteLine("Press '3' fo a new Bow");
            Console.WriteLine($"Price: {_bowPrice}");
            Console.WriteLine("Press '4' for a new Book");
            Console.WriteLine($"Price: {_bookPrice}");
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("A fruitful discount was added if you are intelligent enough!!");
            Console.WriteLine("++++++++++++++++++++++++++++");
            int itemId = Convert.ToInt32(Console.ReadLine());

            if (itemId == 0)
            {
                return false;
            }

            if (Intelligence > 10 && Intelligence <= 15)
            {
                _armorPrice *= 0.9;
                _swordPrice *= 0.9;
                _bowPrice *= 0.9;
                _bookPrice *= 0.9;
            }

            else if (Intelligence > 15)
            {
                _armorPrice *= 0.8;
                _swordPrice *= 0.8;
                _bowPrice *= 0.8;
                _bookPrice *= 0.8;
            }

            switch (itemId)
            {
                case 1:
                    if (Gold >= _armorPrice)
                    {
                        Gold -= _armorPrice;
                        HitPoint += 10;
                        Console.WriteLine($"New armor! HitPoint: {HitPoint}");
                    }

                    else
                    {
                        Console.WriteLine("Insufficient gold!");
                    }

                    break;
                case 2:
                    if (Gold >= _swordPrice)
                    {
                        Gold -= _swordPrice;
                        Strength += 5;
                        Console.WriteLine($"New sword! Strength: {Strength}");
                    }

                    else
                    {
                        Console.WriteLine("Insufficient gold!");
                    }

                    break;
                case 3:
                    if (Gold >= _bowPrice)
                    {
                        Gold -= _bowPrice;
                        Dexterity += 5;
                        Console.WriteLine($"New bow! Dexterity: {Dexterity}");
                    }

                    else
                    {
                        Console.WriteLine("Insufficient gold!");
                    }

                    break;
                case 4:
                    if (Gold >= _bookPrice)
                    {
                        Gold -= _bookPrice;
                        Intelligence += 5;
                        Console.WriteLine($"New book! Intelligence: {Intelligence}");
                    }

                    else
                    {
                        Console.WriteLine("Insufficient gold!");
                    }

                    break;
            }
        }
    }
}