using System;
using System.Collections;

class Program
{
    static void Main()
    {

        ArrayList arrayList = new ArrayList();


        arrayList.Add("Mahadev");
        arrayList.Add(108);
        arrayList.Add(9.99);
        arrayList.Add(true);


        Console.WriteLine("ArrayList elements:");
        DisplayArrayList(arrayList);


        arrayList.Insert(1, "Parvati");


        Console.WriteLine("\nArrayList elements after insertion:");
        DisplayArrayList(arrayList);


        arrayList.Remove(123);


        Console.WriteLine("\nArrayList elements after removal:");
        DisplayArrayList(arrayList);


        Console.WriteLine("\nDoes 'Parvati' exist in the ArrayList? " + arrayList.Contains("Parvati"));


        Console.WriteLine("Index of '3.14': " + arrayList.IndexOf(3.14));


        arrayList.Clear();


        Console.WriteLine("\nArrayList elements after clearing:");
        DisplayArrayList(arrayList);

        Console.WriteLine("Created By Rajan Kumar Verma");
        Console.WriteLine("MCA-2 A, Roll.no:69");
        Console.ReadKey();
        

        
    }


    static void DisplayArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();      
        Console.ReadKey();
    }
    }
    