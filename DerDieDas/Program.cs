namespace DerDieDas
{
    internal class Program
    {
        List<List<string>> dictionary = new List<List<string>>();
        static void Main(string[] args)
        {
            Program program = new Program();
            string word, article;

            //read from file
            string[] saveFile = File.ReadAllLines("c:\\ordlista\\words.txt");
            foreach (string line in saveFile)
            {
                string[] split = line.Split('#');
                program.dictionary.Add(new List<string> { split[0], split[1] });
            }

            string userInput;

            Console.WriteLine("Type 'add' for adding new nouns\nType 'start' to start quiz game");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "add")
            {
                program.AddWord();
            }
            else if (userInput == "start")
            {
                StartGame();
            }
            else
            {
                Console.WriteLine();
            }
        }

        static void StartGame()
        {

        }
        void AddWord()
        {
            int number;
            string word;
            string article;
            string filePath = "c:\\ordlista\\words.txt";

            Console.WriteLine("How many words do you want to add?");
            number = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Type word number {i + 1}:");
                word = Console.ReadLine().ToLower();

                Console.WriteLine("Type type the word's article (der, die, das)");
                article = Console.ReadLine().ToLower();

                Console.Clear();
                dictionary.Add(new List<string> { word, article });
            }

            // save to file
        }
    }
}