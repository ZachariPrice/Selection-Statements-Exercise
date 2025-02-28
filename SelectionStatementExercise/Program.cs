﻿using System;
using System.Diagnostics.Metrics;

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            var favNumber = r.Next(0, 10);
            int userInput;
            var counter = 0;


            do
            {
                Console.WriteLine("Pick a number from 1 - 10");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is to low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is to high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                counter++;

                Console.WriteLine($"You have guessed {counter} times");


            } while (userInput != favNumber);

        }
    }
}
