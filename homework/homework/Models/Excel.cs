using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Models
{
    class Excel : IPrintableFile
    {
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public string FileName { get; set; }

        public Excel(int ColumnCount, int RowCount, string FileName)
        {
            this.ColumnCount = ColumnCount;
            this.RowCount = RowCount;
            this.FileName = FileName;



        }

        public void Print()
        {
            Console.WriteLine($"FileName{FileName} RowCount:{RowCount} ColumnCount:{ColumnCount} ");
        }
    }
}
