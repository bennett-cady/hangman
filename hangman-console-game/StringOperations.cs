namespace hangman_console_game
{

    internal partial class Program
    {
        public class StringOperations
        {

            public static string HideWord(string text)
            {
                string hidden = "";
                foreach (char c in text)
                {
                    if (c == ' ')
                    {
                        hidden += " ";
                    }
                    else
                    {
                        hidden += "-";
                    }
                }
                return hidden;
            }


            public static string Replace(string hidden, string word, char guess)
            {
                char[] hiddenAsArray = hidden.ToCharArray();
                for(int i = 0; i<word.Length; i++)
                {
                    if (word[i] == guess)
                    {
                        hiddenAsArray[i] = guess;   
                    }
                }
                hidden = "";
                foreach (char c in hiddenAsArray)
                {
                    hidden += c;
                }
                return hidden;
            }

            public static bool Guess(string text, char guess)
            {
                return text.Contains(guess);
            }

        }
    }
}