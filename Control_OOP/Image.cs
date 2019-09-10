using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class Image : File
    {
        protected string Resolution;

        public override void SplitStr(string textStr)
        {
            string[] nameSizeContent = textStr.Split(';');
            base.SplitStr(nameSizeContent[0]);
            Extension = nameSizeContent[0].Split('.')[1].Split('(')[0];
            Resolution = nameSizeContent[1];
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" \t\t Resolution: {Resolution}");
        }
    }
}

