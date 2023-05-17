//peyman rasouli 
﻿using Interface1;
using Interface1.classes;
using System.Collections.Generic;

int[] arr = { 2, 3, 5, 7, 8, 9, 0, 1 };
int[] arr2 = { 12, 31, 53, 7, 84, 9, 0, 1, 55, 15, 98, 23 };
int[] inputArray = { 2, 3, 5, 7, 8, 9, 0, 1, 11, 435, 543645, 22, -11 };

Isort Methods;

Methods = new SelectionSort();
Methods = new geneticSort2();
Methods = new geneticSort3();

while (true)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("\nEnter a number(1,2,3):");

    int x = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();

    switch (x)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThis is Method one :");
            Console.ResetColor();

            Methods.Sort(arr);
            Console.WriteLine("\n--------------------------------------------");
            break;

        case 2:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThis is Method two :");
            Console.ResetColor();

            Methods.Sort(arr2);
            Console.WriteLine("\n--------------------------------------------");
            break;

        case 3:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThis is Method Algorithm genetics :");
            Console.ResetColor();

            Methods.Sort(inputArray);
            Console.WriteLine("\n--------------------------------------------");
            break;
    }
}
