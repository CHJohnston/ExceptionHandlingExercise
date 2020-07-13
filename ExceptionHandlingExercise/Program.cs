using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            // DONE - First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = { '1', '2', '3', '4', '5', '6', 'A', 'b', 'C' };

            // DONE - Create a list called numbers that will hold integers
            List<int> numbers = new List<int>();

            //DONE - Create an string variable with an empty string initializer -name it str
            string str = "";

            // DONE - TODO START HERE:
            // DONE - Make a foreach loop to iterate through your character array
            // DONE - Now create a try catch
            // DONE - Inside your try block
            // DONE - set your string variable to each array element in your char[] to .ToString()
            // DONE - Now, using int.Parse, parse your string variable and store in an int variable
            // DONE - Then add each int to your list
            // DONE - catch your Exception:
            // DONE - in the scope of your catch you can use the following, 
            // DONE - Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection

            foreach (var character in arr) 
            {
                try 
                {
                    str = character.ToString();
                    int intvar = int.Parse(str);
                    numbers.Add(intvar);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine();
            Console.WriteLine("This is our list of Numbers");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
