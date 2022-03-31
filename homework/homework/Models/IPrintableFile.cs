using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Models
{
    interface IPrintableFile
    {
        public string FileName { get; set; }
        public void Print();
    }
}
