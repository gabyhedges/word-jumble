using System;
using System.Collections.Generic;

namespace WordJumble2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Word JUmble");
            Console.WriteLine("Unscramble the letters to form a word.Can you solve all 10 puzzles? ");
            //create list
            List<string> words = new List<string> {
       "python",
       "computer",
       "keyboard",
       "mouse",
       "monitor",
       "program",
       "code",
       "algorithym",
       "variable",
       "debug"};


            while (words.Count > 0)
            {
                //randomly select a word from the list
                Random random = new Random();
                int index = random.Next(words.Count);
                string word = words[index];

                //create a jumble version of the word
                char[] letters = word.ToCharArray();
                random = new Random();
                for (int i = 0; i < letters.Length; i++)
                {
                    int j = random.Next(letters.Length);
                    char temp = letters[i];
                    letters[i] = letters[j];
                    letters[j] = temp;

                }

                string jumbledWord = new string(letters);
                //remove the selected word from list
                words.RemoveAt(index);
                //initialise the number of guesses to 0
                int numGuesses = 0;

                while (true)
                {
                    //display the word and state gueses

                    Console.WriteLine($"Unscramble the word: {jumbledWord}");
                    Console.Write("Enter your guess\n");
                    string guess = Console.ReadLine().ToLower();

                    //increment the number of guesses
                    numGuesses++;

                    //check if the guess is correct

                    if (guess == word)
                    {
                        Console.WriteLine($"Congratulations! You unscrambled the word in {numGuesses} guesses.\n");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is incorrect. Please try again.");
                    }
                }
            }


        }
    }
}