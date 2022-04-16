using System;
using System.Collections;
public class SamplesArrayList
{

    public static void Main()
    {

        // Creates and initializes a new ArrayList.
        ArrayList myAL = new ArrayList();
        myAL.Add(104);
        myAL.Add("Neetu");
        myAL.Add("Manager");
        myAL.Add(105);
        myAL.Add("Potter");
        myAL.Add("Developer");

        // Displays the properties and values of the ArrayList.
        Console.WriteLine("*****************************");
        Console.WriteLine("    Count:    {0}", myAL.Count);
        Console.WriteLine("    Capacity: {0}", myAL.Capacity);
        Console.Write("    \n\nValues:");
        PrintValues(myAL);

    }

    public static void PrintValues(IEnumerable myList)
    {
        foreach (Object obj in myList)
            Console.Write("   \n{0}\n", obj);
        Console.WriteLine();
    }
}

