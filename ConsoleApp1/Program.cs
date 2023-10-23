using System;

public abstract class Fruit
{
    public int Price { get; set; }
    public string Sort { get; set; }

    public abstract void Taste();
}

public class Apple : Fruit
{
    public int VitaminA { get; set; }
    public int VitaminB { get; set; }

    public override void Taste()
    {
        Console.WriteLine("Alma ya tursh ya shirin olur.");
    }
}

public class Pineapple : Fruit
{
    public int VitaminE { get; set; }
    public int VitaminD { get; set; }

    public override void Taste()
    {
        Console.WriteLine("Ananas kemshirin ya da shirin olur.");
    }
}

public class Orange : Fruit
{
    public int VitaminC { get; set; }

    public override void Taste()
    {
        Console.WriteLine("Portagal qeribe olur nese.");
    }
}

class Program
{
    static void Main()
    {
        Apple apple = new Apple { Price = 1, Sort = "Red", VitaminA = 10, VitaminB = 20 };
        Pineapple pineapple = new Pineapple { Price = 2, Sort = "Yellow", VitaminE = 30, VitaminD = 40 };
        Orange orange = new Orange { Price = 3, Sort = "Orange", VitaminC = 50 };
        Fruit[] basket = new Fruit[] { apple, pineapple, orange };
        foreach (Fruit fruit in basket)
        {
            if (fruit is Apple)
            {
                Apple appleFruit = (Apple)fruit;
                Console.WriteLine("Apple");
                Console.WriteLine($"Price: {appleFruit.Price}");
                Console.WriteLine($"Sort: {appleFruit.Sort}");
                Console.WriteLine($"VitaminA: {appleFruit.VitaminA}");
                Console.WriteLine($"VitaminB: {appleFruit.VitaminB}");
            }
            else if (fruit is Pineapple)
            {
                Pineapple pineappleFruit = (Pineapple)fruit;
                Console.WriteLine("Pineapple");
                Console.WriteLine($"Price: {pineappleFruit.Price}");
                Console.WriteLine($"Sort: {pineappleFruit.Sort}");
                Console.WriteLine($"VitaminE: {pineappleFruit.VitaminE}");
                Console.WriteLine($"VitaminD: {pineappleFruit.VitaminD}");
            }
            else if (fruit is Orange)
            {
                Orange orangeFruit = (Orange)fruit;
                Console.WriteLine("Orange");
                Console.WriteLine($"Price: {orangeFruit.Price}");
                Console.WriteLine($"Sort: {orangeFruit.Sort}");
                Console.WriteLine($"VitaminC: {orangeFruit.VitaminC}");
            }
            Console.WriteLine(">>>");
        }
    }
}
