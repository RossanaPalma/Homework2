/// Chapter No. 2		Exercise No. 2
/// File Name: Program.cs - Part 1 
/// /// @author: Rossana Palma
/// Date:  September 14, 2020
///
/// Problem Statement: Write a program with string variables with first and last names and create a new string with full name in pig latin,
/// and display the pig latin name to the screen.
/// 
/// Overall Plan:
/// 1) Assignment names to String
/// 2) Use the pig latin rule
/// 3) Output the pig latin name to the screen


using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            String first; 
            String last;  
            String pigLatinFirst;
            String pigLatinLast;
            String pigLatinName;

            // Assigning names to String
            first   =   "rossana"; 
            last    =   "palma";


            pigLatinFirst = first.Substring(1)  + first.Substring(0, 1) + "ay";
            pigLatinLast = last.Substring(1) + last.Substring(0, 1)  + "ay";


            pigLatinFirst = pigLatinFirst.Substring(0, 1).ToUpper() + pigLatinFirst.Substring(1);
            pigLatinLast = pigLatinLast.Substring(0, 1).ToUpper() + pigLatinLast.Substring(1);

            pigLatinName = pigLatinFirst + " " + pigLatinLast;

            Console.WriteLine("First Name:      " + first);
            Console.WriteLine("Last Name:       " + last);
            Console.WriteLine("Pig Latin Name:  " + pigLatinName);


        }

    }
}