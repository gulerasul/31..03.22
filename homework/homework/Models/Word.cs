using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Models
{
    class Word:IPrintableFile
    {
        public int WordCount { get; set; }
        public string FileName { get ; set; }

        public Word(int WordCount, string FileName)
        {
            this.WordCount = WordCount;
            this.FileName = FileName;

        }

        public void Print()
        {
            Console.WriteLine($"WorCount:{WordCount} FileNme:{FileName}");
        }
    }
}
