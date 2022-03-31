using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Models
{
    class Pdf:IPrintableFile
    {
        public int PageCount { get; set; }
        public string FileName { get ; set ; }

        public Pdf(int PageCount,string FileName)
        {
            this.PageCount = PageCount;
            this.FileName = FileName;

        }

        public void Print()
        {
            Console.WriteLine($"PageCount:{PageCount} FileNme:{FileName}");
        }
    }
}
