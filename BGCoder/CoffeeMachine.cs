using System;

class CoffeeMachine
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        double sum = (0.05 * n1) + (0.10 * n2) + (0.20 * n3) + (0.50 * n4) + (1 * n5);
        double amount = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        if (price > amount) 
        {
            Console.WriteLine("More {0:0.00}", price - amount);
        }
        else if (sum < amount - price) 
        {
            Console.WriteLine("No {0:0.00}" , (amount - price) - sum);
        }
        else if (sum >= amount - price) 
        {
            Console.WriteLine("Yes {0:0.00}", sum - (amount - price));
        }
    }
}