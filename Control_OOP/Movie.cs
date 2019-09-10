using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class Movie : Image
    {
        private string Length;

        public override void SplitStr(string textStr)
        {
            base.SplitStr(textStr);
            string[] nameSizeContent = textStr.Split(';');
            Length = nameSizeContent[2];
            Extension = nameSizeContent[0].Split('.')[2].Split('(')[0];
            Resolution = nameSizeContent[1];
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" \t\t Length: {Length}");
        }
    }
}

