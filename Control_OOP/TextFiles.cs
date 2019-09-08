using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class TextFiles : Files
    {
        protected string Content;

        public TextFiles[] SplitParts(My_List<string> textList)
        {
            TextFiles[] textArr = new TextFiles[textList.Count];

            for (int x = 0; x < textArr.Length; x++)
            {
                textArr[x] = new TextFiles();
            }
            for (int i = 0; i < textList.Count; i++)
            {
                if (textList[i] != null)
                {
                    textArr[i].NameFile = textList[i].Split(':')[1].Split('(')[0];
                    textArr[i].Extension = textList[i].Split('.')[1].Split('(')[0];
                    textArr[i].Size = textList[i].Split('(')[1].Split(')')[0];
                    textArr[i].Content = textList[i].Split(';')[1].Split('\n')[0];
                }
            }
            return textArr;
        }
        public TextFiles[] SortSize(TextFiles[] textArray)
        {
            TextFiles temp;
            for (int j = 0; j < textArray.Length; j++)
            {
                for (int i = 0; i < textArray.Length - j - 1; i++)
                {
                    textArray[i].Size = textArray[i].Size.Split('B')[0];
                    if (double.TryParse(textArray[i].Size, out double sizei))
                        textArray[i + 1].Size = textArray[i + 1].Size.Split('B')[0];
                    if (double.TryParse(textArray[i + 1].Size, out double size1))
                        if (sizei > size1)
                        {
                            temp = textArray[i];
                            textArray[i] = textArray[i + 1];
                            textArray[i + 1] = temp;
                        }
                }
            }
            return textArray;
        }
        public void Print(TextFiles[] textArrSort)
        {
            Console.WriteLine("Text files:");
            for (int i = 0; i < textArrSort.Length; i++)
            {
                Console.WriteLine($"\t{textArrSort[i].NameFile}\n \t\tExtension: {textArrSort[i].Extension}\n" +
                    $" \t\tSize: {textArrSort[i].Size}B\n" +
                    $" \t\tContent: {textArrSort[i].Content}");
            }
        }
    }
}
