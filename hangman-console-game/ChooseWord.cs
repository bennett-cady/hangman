using System.Reflection.PortableExecutable;

namespace hangman_console_game
{
    internal partial class ChooseWord 
    {

        public static int GetLineCount()
        {
            var LastLineNumber = 0;
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\bjcad\source\repos\hangman-console-game\hangman-console-game\words.txt"))
            {  
                while (file.ReadLine() != null)
                {
                    LastLineNumber++;
                }
            }
            return LastLineNumber;
        }
    
        public static List<String> GetLines()
        {
            List<String> lines = new List<String>();
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\bjcad\source\repos\hangman-console-game\hangman-console-game\words.txt"))
            {
                var LineCount = GetLineCount();
                for (int i = 0; i < LineCount; ++i)
                {
                    lines.Add(file.ReadLine());
                }
            }
            return lines;
        }

        public static string SelectWord()
        {
            List<String> words = GetLines();
            Random rand = new Random();
            int index = rand.Next(0, words.Count);
            return words.ElementAt(index);
        }

    }
}