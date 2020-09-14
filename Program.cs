///Chapter No. 2		Exercise No. 2
/// File Name: Program.cs - Part 2 
/// /// @author: Rossana Palma
/// Date:  September 14, 2020
///
/// Problem Statement: Write a program that converts degrees Fahrenheit to Celsius using formula and display the equivalent Celsius
/// temperature with one decimal point.
/// 
/// Overall Plan:
/// 1) Ask for temperature in degrees Fahrenheit 
/// 2) Convert Fahrenheit degrees in Celsius degrees
/// 3) Display Celsius degrees including the fractional part one decimal point.

using System;
using System.Transactions;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
           int fahrenheit;
           int celsius;
                                   
           Console.WriteLine("Enter a temperature in degrees Fahrenheit:   ");

           fahrenheit = Convert.ToInt32(Console.ReadLine());
           celsius = (fahrenheit - 32) * 5 / 9;
           
           Console.WriteLine(fahrenheit + " degrees Fahreinhet = " + celsius + " degrees Celsius" );
           
        }
    }
}
