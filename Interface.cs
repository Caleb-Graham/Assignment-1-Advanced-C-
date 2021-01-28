using System;

    interface IPurchasable
        {
        double Price { get; set; }

        double Purchase();   //Changed to double
    }

    interface IShippable
        {
        double ShippingRate { get; set; }
        double Ship();  //Changed to double
        }

    interface ITaxable
        {
        double TaxRate { get; set; }
        double Tax();
        }


public class Appointment : IPurchasable
    {
    public string Name { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public double Price { get; set; }

    public double Purchase()
        {
        Console.WriteLine($"Payment for Appointment for {Name} from {StartDateTime} to {EndDateTime} for {Price.ToString("C0")}.");
        return Price;       // Added return statements for all Purchase methods
        }
    }

public class Book : IPurchasable, ITaxable, IShippable
    {
    public string Title { get; set; }
    public double Price { get; set; }
    public double TaxRate { get; set; }
    public double ShippingRate { get; set; }    // Added ShippingRate to allow interface to be accessible

    public double Purchase()
        {
        Console.WriteLine($"Purchasing {Title} for {Price.ToString("C0")}.");
        return Price;
        }

    public double Tax()
        {
        var tax = Price * TaxRate;
        Console.WriteLine($"    TaxRate: {TaxRate} = {tax}");
        return tax;
        }

    public double Ship()        // Added Ship method to get shipping cost for an item
        {
        var ship = ShippingRate;
        Console.WriteLine($"    ShippingRate: ${ship}");
        return ship;
        }

    }

public class TShirt : IPurchasable, ITaxable, IShippable
    {
    public double Price { get; set; }
    public string Size { get; set; }
    public double TaxRate { get; set; }
    public double ShippingRate { get; set; }      // Added ShippingRate to allow interface to be accessible

    public double Purchase()
        {
        Console.WriteLine($"Purchasing TShirt {Size} for {Price.ToString("C0")}.");
        return Price;
        }

    public double Tax()
        {
        var tax = Price * TaxRate;
        Console.WriteLine($"    TaxRate: {TaxRate} = {tax}");
        return tax;
        }

    public double Ship()        // Added Ship method to get shipping cost for an item
        {
        var ship = ShippingRate;
        Console.WriteLine($"    ShippingRate: ${ship}");
        return ship;
        }
    }

public class Snack : IPurchasable
    {
    public double Price { get; set; }

    public double Purchase()
        {
        Console.WriteLine($"Purchasing a snack for {Price.ToString("C0")}.");
        return Price;
        }
    }

