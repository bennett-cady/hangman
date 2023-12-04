namespace hangman_console_game
{

    internal partial class Program
    {

        /*
         * TO-DO
         * 
         * Read from a file of potential words/phrases
         * Randomly select word/phrase from this list
         * Display number of guesses used/ total amount
         * Display the hidden word, filled in with correct guesses
         * Display a list of incorrect guesses
         * A function to validate input: ensure only characters, standardize casing
         * Do not allow player to make the same guess more than once
         */

        public static void PlayGame()
        {
            byte misses = 0;
            bool found = false;
            string history = "";

            Console.WriteLine("Welcome to hangman! Press y if you would like to play");
            string a = Console.ReadLine();
            if (a.Length > 0 && a.Equals("y"))
            {
                Console.WriteLine("Great! Let's get started");
            }
            else
            {
                Console.WriteLine("Okay, maybe later...");
            }

            string word = "try and guess me";
            string hidden = StringOperations.HideWord(word);
            Console.WriteLine(hidden);
            //Console.WriteLine(StringOperations.Replace(hidden, word, 'o'));  

            while(misses<7 && found==false)
            {
                Console.WriteLine(" ");
                if(misses>0) Console.WriteLine("Your previous guesses: " + history);
                Console.WriteLine("Enter a guess: ");
                string guess = Console.ReadLine();
                if(guess.Length==1)
                {
                    if(word.Contains(guess))
                    {
                        hidden = StringOperations.Replace(hidden, word, guess[0] );
                        Console.WriteLine("Correct!");

                    }   else
                    {
                        misses++;
                        history += guess;
                        Console.WriteLine("Wrong!");
                    }
                } else { Console.WriteLine("Please enter a valid character (a-z)"); }
                Console.WriteLine(" ");
                Console.WriteLine(hidden);
                Console.WriteLine("Tries: " + misses + "/7");

                if(!hidden.Contains('-')) 
                {
                    found = true;
                }
            }

            if(found)
            {
                Console.WriteLine("Congrats! You won!!");
            } else { Console.WriteLine("Better luck next time!"); }

             
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PlayGame();
        }
    }
}