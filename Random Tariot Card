using System;

// Enum representing the major tarot cards
public enum MajorTarotCards
{
    TheFool,//Each tarot card is listed as a member of the enum. By default, the first value (TheFool) is assigned the integer value 0, the second value (TheMagician) is assigned 1, and so on, up to TheWorld, which is assigned 21.
    TheMagician,
    TheHighPriestess,
    TheEmpress,
    TheEmperor,
    TheHierophant,
    TheLovers,
    TheChariot,
    Strength,
    TheHermit,
    WheelOfFortune,
    Justice,
    TheHangedMan,
    Death,
    Temperance,
    TheDevil,
    TheTower,
    TheStar,
    TheMoon,
    TheSun,
    Judgement,
    TheWorld
}

// Main class of the program
public class Program
{
    // Entry point of the program
    public static void Main()
    {
        // Creating a random number generator
        Random random = new Random();

        // Enum.GetValues Method: Enum.GetValues(typeof(MajorTarotCards)) returns an array of all values in the MajorTarotCards enum. The typeof keyword is used to get the type of the enum.
        //Length: Enum.GetValues(typeof(MajorTarotCards)).Length gets the length of this array, which is 22 in this case (because there are 22 tarot cards).
        //Random Number Generation: random.Next(22) generates a random integer between 0 (inclusive) and 22 (exclusive). This means it will generate a number between 0 and 21, corresponding to the enum values of the tarot cards.
        int randomIndex = random.Next(Enum.GetValues(typeof(MajorTarotCards)).Length);

        // Type Casting: (MajorTarotCards)randomIndex casts the integer randomIndex to the corresponding MajorTarotCards enum value. For example, if randomIndex is 3, it will be cast to MajorTarotCards.TheEmpress.
        MajorTarotCards selectedCard = (MajorTarotCards)randomIndex;

        //String Formatting: String.Format("Randomly selected card is {0}.", selectedCard) creates a formatted string where {0} is replaced by the selectedCard value (e.g., "TheEmpress").
        Console.WriteLine(String.Format("Randomly selected card is {0}.", selectedCard));
        //Method Call: DescribeCard(selectedCard) calls the DescribeCard method, passing the randomly selected card as an argument.
        DescribeCard(selectedCard); // Calling a method to describe the selected card
    }

    // Method to describe the selected major tarot card
    public static void DescribeCard(MajorTarotCards card)
    {
        switch (card)
        {
            case MajorTarotCards.TheFool:
                Console.WriteLine("The Fool represents new beginnings, innocence, and spontaneity.");
                break;

            case MajorTarotCards.TheMagician:
                Console.WriteLine("The Magician signifies creativity, power, and manifestation of goals.");
                break;

            case MajorTarotCards.TheHighPriestess:
                Console.WriteLine("The High Priestess represents intuition, mystery, and inner knowledge.");
                break;

            case MajorTarotCards.TheEmpress:
                Console.WriteLine("The Empress symbolizes abundance, nurturing, and fertility.");
                break;

            case MajorTarotCards.TheEmperor:
                Console.WriteLine("The Emperor embodies authority, stability, and leadership.");
                break;

            case MajorTarotCards.TheHierophant:
                Console.WriteLine("The Hierophant signifies tradition, spirituality, and guidance.");
                break;

            case MajorTarotCards.TheLovers:
                Console.WriteLine("The Lovers represent love, relationships, and choices.");
                break;

            case MajorTarotCards.TheChariot:
                Console.WriteLine("The Chariot symbolizes control, willpower, and determination.");
                break;

            case MajorTarotCards.Strength:
                Console.WriteLine("Strength represents inner strength, courage, and overcoming challenges.");
                break;

            case MajorTarotCards.TheHermit:
                Console.WriteLine("The Hermit signifies introspection, solitude, and inner guidance.");
                break;

            case MajorTarotCards.WheelOfFortune:
                Console.WriteLine("The Wheel of Fortune symbolizes change, luck, and cycles of life.");
                break;

            case MajorTarotCards.Justice:
                Console.WriteLine("Justice represents fairness, balance, and accountability.");
                break;

            case MajorTarotCards.TheHangedMan:
                Console.WriteLine("The Hanged Man signifies surrender, sacrifice, and new perspectives.");
                break;

            case MajorTarotCards.Death:
                Console.WriteLine("Death symbolizes transformation, endings, and new beginnings.");
                break;

            case MajorTarotCards.Temperance:
                Console.WriteLine("Temperance represents balance, moderation, and harmony.");
                break;

            case MajorTarotCards.TheDevil:
                Console.WriteLine("The Devil symbolizes materialism, temptation, and bondage.");
                break;

            case MajorTarotCards.TheTower:
                Console.WriteLine("The Tower signifies upheaval, chaos, and sudden change.");
                break;

            case MajorTarotCards.TheStar:
                Console.WriteLine("The Star represents hope, inspiration, and spiritual guidance.");
                break;

            case MajorTarotCards.TheMoon:
                Console.WriteLine("The Moon symbolizes illusion, intuition, and the subconscious mind.");
                break;

            case MajorTarotCards.TheSun:
                Console.WriteLine("The Sun signifies success, joy, and vitality.");
                break;

            case MajorTarotCards.Judgement:
                Console.WriteLine("Judgement represents reflection, renewal, and awakening.");
                break;

            case MajorTarotCards.TheWorld:
                Console.WriteLine("The World symbolizes completion, accomplishment, and fulfillment.");
                break;

            default:
                Console.WriteLine("Unknown card.");
                break;
        }
    }
}
