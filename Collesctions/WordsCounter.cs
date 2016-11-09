using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collesctions
{
    class WordsCounter
    {
        public Dictionary<string, int> Counter(string text)
        {
            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
            string[] input = text.Split(new char[] { ' ', ',', '.', '?', ';', '!', ':', '"', }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                if (wordsCounter.ContainsKey(input[i]))
                {
                    wordsCounter[input[i]] = wordsCounter[input[i]] + 1;
                    // another way - dull : )
                    //int currentValue; 
                    //wordsCounter.TryGetValue(input[i], out currentValue);
                    //wordsCounter[input[i]] = currentValue + 1;
                }
                else
                {
                    wordsCounter.Add(input[i], 1);
                }
            }

            return wordsCounter;
        }
    }
}
