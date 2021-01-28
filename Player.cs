using System;


internal class Player
    {
    public Player()
        {
        }

    public virtual string Name { get; set; }    // Add Virtual keyword
    public virtual int Strength { get; set; }   // Add Virtual keyword

    internal virtual void Attack()  // Add Virtual keyword
        {
        Random rand = new Random();
        Console.WriteLine($"{Name} attacked for " + rand.Next(Strength + 1) + " damage.");
        }
    }


internal class Warrior : Player
    {
    public Warrior()
        {
        }

    public override string Name { get; set; }   // Add Override keyword
    public override int Strength { get; set; }  // Add Override keyword
    public int Bonus { get; set; }

    internal override void Attack() // Add Override keyword
        {
        Random rand = new Random();
        Console.WriteLine($"{Name} charges for " + rand.Next(Strength + 1) + " damage" + 
            "(inclueds +" + rand.Next(Bonus + 1) + " bonus).");
        }
    }


internal class Wizard : Player
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
            "\n" + "    (Wizard " + Name + " depleted " + rand.Next(Energy + 1) + " energy).");
        }
    }

  







