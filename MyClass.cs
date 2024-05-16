using System;
using System.Threading;  // Required for Thread.Sleep (3)

public class Program
{
    public Health PresidentsHealth;
    public Damage Bullet;

    public void Main()
    {
        PresidentsHealth = new Health();// this is (1) this is saying that thw word PresidentsHealth is getting referred to (2)
        Bullet = new Damage();

      PresidentsHealth.PrHealth -= Bullet.BuDamage; // Decrease the health
        
        Console.WriteLine("Hello Wor... IM ALIVE");
		
		// Wait for 1 second before proceeding also this is only possible if i add (using System.Threading at (3))
        Thread.Sleep(1000);
        Console.WriteLine("GET DOWN MR PRESIDENT!!!");
		
		
        Thread.Sleep(1000);
        Console.WriteLine("BANG!!!");
		
		
        Thread.Sleep(1000);
       	Console.WriteLine(PresidentsHealth.Name + " WARNING HEALTH HALF WAY!!! " + PresidentsHealth.PrHealth); // remember PresidentHealth is referring to (1)
		
        Thread.Sleep(1000);
		
		// Display options to the person
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Bandage wound");
        Console.WriteLine("2. try to see the shooter");

        // Get the persons choice
        Console.Write("Enter your choice (1 or 2): ");
		// this is so the program can read what the person put in
        string userChoice = Console.ReadLine();
		// this "==" means that its checking if its even or true or false to the choice the person inputted
		// if is an option like its checking like a true or false
		 if (userChoice == "1")
        {
            // Option 1 outcome
            Console.WriteLine("you stop the bleeding and are safe for now");
        }
        else if (userChoice == "2")
        {
            // Option 2 outcome
            Console.WriteLine("You peak from your cover and lose your head from a sniper shot. YOU DIE!");
        }
        else
        {
            // Invalid choice outcome 
			// this is if the person inputs anything other than 1 or 2
            Console.WriteLine("Invalid choice. Please restart the program and choose either 1 or 2.");
        }
    }

    public class Health // this is (2) this is were i can spcify what i want from here like if i want PrHealth i just put .PrHealth after PresidentsHealth like this PresidentsHealth.PrHealth
    {
        // This is the health of the president
        public int PrHealth = 50;
        public string Name = "President";
    }

    public class Damage
    {
        // This is the damage to the president's health
        public int BuDamage = 25;
    }
}
