using System;
public class swapping
{
    public static void Main(string[] args)
    {
        int number1, number2, temp;
        Console.Write("\nInput the First Number : ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("\nInput the Second Number : ");
        number2 = int.Parse(Console.ReadLine());
        Console.Write("\nBefore Swapping : ");
        Console.Write("\nFirst Number : " + number1);
        Console.Write("\nSecond Number : " + number2);
        Console.WriteLine();
        Console.WriteLine();
        temp = number1;
        number1 = number2;
        number2 = temp;
        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + number1);
        Console.Write("\nSecond Number : " + number2);
        Console.Read();
    }
}

