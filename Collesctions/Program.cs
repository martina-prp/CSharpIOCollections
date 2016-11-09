using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collesctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
            string input = Console.ReadLine();
            WordsCounter words = new WordsCounter();
            wordsCounter = words.Counter(input);
            foreach(KeyValuePair<string, int> item in wordsCounter) // Or foreach(var item in wordsCounter)
            {
                Console.WriteLine("{0}: {1} times.", item.Key, item.Value);
            }
        }
    }
}
