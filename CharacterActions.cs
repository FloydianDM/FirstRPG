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
        var drinkID = Convert.ToInt32(Console.ReadLine());

        switch (drinkID)
        {
            case 1:
                Console.WriteLine("Drinking a glass of tasty, bitter and herbal ale...");
                Gold -= 5;
                HitPoint += 5;
                break;
            case 2:
                Console.WriteLine("Drinking a jar of full bodied red wine, feeling like a noble prick...");
                Gold -= 15;
                HitPoint += 20;
                break;
            case 3:
                Console.WriteLine("Game over vahhabi köpeği!");
                HitPoint = 0;
                break;
        }
        
        CheckHealth();
    }

    public int SetFight (int encounterStrength)
    {
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

        return HitPoint;
    }
}