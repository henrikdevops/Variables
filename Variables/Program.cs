﻿
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {
        /* 
        int x;
        int y;

        x = 7;
        y = x + 3;

        Console.WriteLine(y);
        Console.ReadLine();
        */

        Console.WriteLine("What is your name?");
        Console.Write("Type your name: ");
        string myFirstName;
        myFirstName = Console.ReadLine();

        //string myLastName;
        //Console.Write("Type your last name:");
        //myLastName = Console.ReadLine();

        Console.WriteLine("Type your last name: ");
        string myLastName = Console.ReadLine();

        Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
        Console.ReadLine();
    }
}
