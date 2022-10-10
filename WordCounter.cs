using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
     class WordCounter
    {
        private readonly object _locker = new object();

        private Dictionary<string, int> _wordCountDictionary  = new Dictionary<string, int>();
        public void take(String word){
            lock (_locker)
            {

                if (_wordCountDictionary.ContainsKey(word))
                {
                    _wordCountDictionary[word] += 1;
                }
                else
                {
                    _wordCountDictionary[word] = 1;
                }
            }
        }

        public int count(String word) {
            if (_wordCountDictionary.ContainsKey(word))
            {
                return _wordCountDictionary[word];

            }

            return 0;
        }

    }
}
