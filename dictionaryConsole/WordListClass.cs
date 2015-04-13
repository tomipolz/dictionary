using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryConsole
{
    public class WordListClass
    {
        public void Main()
        {
            Console.WriteLine("Word list class launched");
        }

        public List<String> words = new List<string> { "Hello", "Welcome", "Goodbye" };
    }
}
