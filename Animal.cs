using System;


class Animal  // Base class (parent) 
    {
    public virtual void animalSound()   // Add Virtual keyword
        {
        Console.WriteLine("The animal makes a sound");
        }
    }

class Pig : Animal  // Derived class (child) 
    {
    public override void animalSound()  // Add Override keyword
        {
        Console.WriteLine("The pig says: wee wee");
        }
    }

class Dog : Animal  // Derived class (child) 
    {
    public override void animalSound()  // Add Override keyword
        {
        Console.WriteLine("The dog says: bow wow");
        }
    }







