using System;


internal class Player
    {
    public Player()
        {
        }

    public string Name { get; set; }
    public int Strength { get; set; }

    internal void Attack()
        {
        throw new NotImplementedException();
        }
    }


internal class Warrior : Player
    {
    public Warrior()
        {
        }

    public string Name { get; set; }
    public int Strength { get; set; }
    public int Bonus { get; set; }
}


internal class Wizard : Player
    {
    public Wizard()
        {
        }

    public string Name { get; set; }
    public int Strength { get; set; }
    public int Energy { get; set; }
    }







