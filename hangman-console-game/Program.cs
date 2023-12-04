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
         */

        public static void PlayGame()
        {
            byte guesses = 0;
            bool found = false;

            Console.WriteLine("Welcome to hangman! Press y if you would like to play");
            String a = Console.ReadLine();
            if (a.Length > 0 && a.Equals("y"))
            {
                Console.WriteLine("Great! Let's get started");
            }
            else
            {
                Console.WriteLine("Okay, maybe later...");
            }
            /*
            while(guesses<7 || found==false)
            {
                Console.WriteLine('Play game here');

                if(!word.contains('-')) 
                {
                    found = true;
                }
            }
            */


            string word = "Choose word";
            string output = StringOperations.HideWord(word);
            Console.WriteLine(output);
            Console.WriteLine(StringOperations.Replace(output, word, 'o'));   
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PlayGame();
        }
    }
}