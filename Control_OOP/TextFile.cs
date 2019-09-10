using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class TextFile : File
    {
        private string Content;
        
        public My_List SplitStr(string textStr, ref My_List size)
        {
            string[] nameSizeContent = textStr.Split(';');
            base.SplitStr(nameSizeContent[0]);
            Extension = nameSizeContent[0].Split('.')[1].Split('(')[0];
            Content = nameSizeContent[1];
            size.Add(Size);
            return size;
        }
        public My_List SortSize(My_List size, My_List textFile)
        {
            object temp;
            string[] sizeArray = new string[size.Count];
            for (int x = 0; x < size.Count; x++)
            {
                sizeArray[x] = size[x].ToString();
            }
            for (int j = 0; j < sizeArray.Length; j++)
            {
                for (int i = 0; i < sizeArray.Length - j - 1; i++)
                {
                    string temp1 = sizeArray[i].Split('B')[0];
                    string temp2 = sizeArray[i + 1].Split('B')[0];
                    if (double.TryParse(temp1, out double sizei))
                        if (double.TryParse(temp2, out double size1))
                            if (sizei > size1)
                            {
                                temp = textFile[i];
                                textFile[i] = textFile[i + 1];
                                textFile[i + 1] = temp;
                            }
                }
            }
            return textFile;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" \t\t Content: {Content}");
        }
    }
}

