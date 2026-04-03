using System;

public class Churros
{
    public void ShowMenu()
    {
        Console.WriteLine("     Delicious Churros        c");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Plain Sugar - €6");
        Console.WriteLine("2. Cinnamon Sugar - €6");
        Console.WriteLine("3. Chocolate Sauce - €8");
        Console.WriteLine("4. Nutella - €8");
    }

    public double GetPrice(int choice)
    {
        switch (choice)
        {
            case 1:
            case 2:
                return 6;
            case 3:
            case 4:
                return 8;
            default:
                return 0;
        }
    }

    public string GetItemName(int choice)
    {
        switch (choice)
        {
            case 1: return "Plain Sugar";
            case 2: return "Cinnamon Sugar";
            case 3: return "Chocolate Sauce";
            case 4: return "Nutella";
            default: return "Invalid";
        }
    }
}