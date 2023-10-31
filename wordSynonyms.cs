namespace softUni_AssocArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();

            List<string> inputWords = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 2 * n; i++)
            {
                string word = Console.ReadLine();
                inputWords.Add(word);
            }

            for(int i = 0; i < inputWords.Count; i++)
            {
                string inputWord = inputWords[i];
                if(i % 2 == 0)
                {
                    if(!words.ContainsKey(inputWord)) words.Add(inputWord, new List<string>());
                    string synonym = inputWords[i + 1];
                    words[inputWord].Add(synonym);
                }
            }

            foreach(var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", words[word.Key])}");
            }
        }
    }
}