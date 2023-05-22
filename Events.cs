using System.Net.Http.Headers;

namespace FirstRPG;

public class Events : Input
{
    public Events()
    {
        
    }

    public void Bar1()
    {
        Console.WriteLine("+++++ Chapter 1 +++++");
        Console.WriteLine("A long journey is ahead. First I need to drink something to replenish my energy before a very intense combat.");
        Console.WriteLine("This is my favourite place to drink like a champ.");
        Character.SetDrink();
        Console.WriteLine("==============================================================");
        Console.WriteLine("There is one mercenary watching me, I need to be very careful.");
        Console.WriteLine("Let's prepare to a hard fight!");
        Random random = new Random();
        int encounterStrength = random.Next(5, 15);
        int encounterDexterity = random.Next(5, 15);
        int encounterIntelligence = random.Next(0, 10);
        int encounterVitality = random.Next(15, 25);
        Character.SetFight(encounterStrength, encounterDexterity, encounterIntelligence, encounterVitality);
        Console.WriteLine("After this exhausting fight, I need to replenish myself.");
    }

    public void Village1()
    {
        Console.WriteLine("+++++ Chapter 2 +++++");
        Console.WriteLine("+++++ Village of the Freedom +++++");
        Console.WriteLine("I have limited time, I can replenish my health here or do some exercises.");
        Console.Write("Do you want to train? (y/n) ");
        string train = Console.ReadLine();

        switch (train)
        {
            case "y" :
                Character.SetTraining();
                break;
            case "n" :
                Character.SetReplenish();
                break; ;
        }

        Console.WriteLine("Let's leave.");
    }
}