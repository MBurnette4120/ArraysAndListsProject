using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10 - DONE
            int[] newArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //Create two Lists of type int.
            //Name one List "evens"  DONE
            var evens = new List<int>();

            //Name the other List "odds"   DONE
            ///
            var odds = new List<int>();

            /* Using either a foreach or for loop,   - DONE
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            //------------------------------section-----------------------------
            foreach (var num in newArray)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }

                Console.WriteLine("");




                //Now using foreach or for loops,
                //* display each List of even and odd numbers
                //*
                //* Try to be creative in your display
                //*/  DONE
                foreach (var item in odds)
                {
                    Console.WriteLine(item);

                }

                Console.WriteLine("");
                Console.WriteLine("The even numbers are:");


                foreach (var item in evens)
                {


                    Console.WriteLine($"{item}");

                }

                
            }
        }
    }
}
