using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordCounter = new WordCounter();
            wordCounter.take("aa");
            wordCounter.take("aa");
            wordCounter.take("bb");
            Console.WriteLine(wordCounter.count("aa"));
            Console.WriteLine(wordCounter.count("bb"));
            Console.WriteLine(wordCounter.count("cc"));

        }
    }
}
