using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class Images : Files
    {
        protected string Resolution;
        
        public Images[] SplitParts(My_List<string> imageList)
        {
            Images[] imageArr = new Images[imageList.Count];

            for (int x = 0; x < imageArr.Length; x++)
            {
                imageArr[x] = new Images();
            }
            for (int i = 0; i < imageList.Count; i++)
            {
                if (imageList[i] != null)
                {
                    imageArr[i].NameFile = imageList[i].Split(':')[1].Split('(')[0];
                    imageArr[i].Extension = imageList[i].Split('.')[1].Split('(')[0];
                    imageArr[i].Size = imageList[i].Split('(')[1].Split(')')[0];
                    imageArr[i].Resolution = imageList[i].Split(';')[1].Split('\n')[0];
                }
            }
            return imageArr;
        }
        public void Print(Images[] imageArr)
        {
            Console.WriteLine("Images:");
            for (int i = 0; i < imageArr.Length; i++)
            {
                Console.WriteLine($"\t{imageArr[i].NameFile}\n \t\tExtension: {imageArr[i].Extension}\n" +
                    $" \t\tSize: {imageArr[i].Size}\n" +
                    $" \t\tResolution: {imageArr[i].Resolution}");
            }
        }
    }
}
