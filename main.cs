// Created by: Jaejun Lee
// Created on: Mar 2022
//
// This program accepts user input
using System;
class Program
{
    public static void Main(string[] args)
    {
        float length;
        float width;
        float height;
        float volume;

        Console.WriteLine("This program calculates the volume of a pyramid.");
        Console.WriteLine("");
        Console.Write("Enter the length (cm): ");
        length = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter the width (cm): ");
        width = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        height = Convert.ToSingle(Console.ReadLine());

        volume = (length * width * height) / 3;

        Console.WriteLine("");
        Console.Write("The volume of the pyramid = " + volume.ToString("0.00") + " cm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}
