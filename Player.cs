using System;

internal class Player
    {
    public Player() // Parent Class
        {
        }

    public virtual string Name { get; set; }    // Add Virtual keyword
    public virtual int Strength { get; set; }   // Add Virtual keyword

    internal virtual void Attack()  // Add Virtual keyword
        {
        Random rand = new Random();     // Instantiate rand of Random class
        Console.WriteLine($"{Name} attacked for " + rand.Next(Strength + 1) + " damage.");  // Use rand to call a number between 0 and Strength
        }
    }


internal class Warrior : Player   // Child class
    {
    public Warrior()
        {
        }

    public override string Name { get; set; }   // Add Override keyword
    public override int Strength { get; set; }  // Add Override keyword
    public int Bonus { get; set; }

    internal override void Attack() // Add Override keyword (Allows the same method to have different outputs thanks to polymorphism)
        {
        Random rand = new Random();
        Console.WriteLine($"{Name} charges for " + rand.Next(Strength + 1) + " damage" +   
            "(includes +" + rand.Next(Bonus + 1) + " bonus).");
        }
    }


internal class Wizard : Player   // Child class
    {
    public Wizard()
        {
        }

    public override string Name { get; set; }   // Add Override keyword
    public override int Strength { get; set; }  // Add Override keyword
    public int Energy { get; set; }

    internal override void Attack() // Add Override keyword
        {
        Random rand = new Random();
        Console.WriteLine($"{Name} attacked for " + rand.Next(Strength + 1) + " damage." +
            "\n" + "    (Wizard " + Name + " depleted " + rand.Next(1, 11) + " energy).");  // Depletes only between 1,10 damage as specified
        }
    }

  







