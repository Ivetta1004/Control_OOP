using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class File
    {
        protected string NameFile;
        protected string Extension;
        public string Size;

        public virtual void SplitStr(string textStr)
        {
            string[] nameSize = textStr.Split('(', ')');
            NameFile = nameSize[0];
            Size = nameSize[1];
        }
        public virtual void Print()
        {
            Console.WriteLine($"\t {NameFile}");
            Console.WriteLine($"\t\t Extension: {Extension}");
            Console.WriteLine($"\t\t Size: {Size}");
        }
    }
}
