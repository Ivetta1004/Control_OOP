using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class Files
    {
        protected string NameFile;
        protected string Extension;
        protected string Size;

        public void StructFiles(string[] splitStr)
        {
            My_List<string> textList = new My_List<string>();
            My_List<string> imageList = new My_List<string>();
            My_List<string> movieList = new My_List<string>();
            TextFiles textFiles = new TextFiles();
            Images images = new Images();
            Movies movies = new Movies();
            int i = 0;
            while (i < splitStr.Length)
            {
                string typeFile = splitStr[i].Split(':')[0].Trim();
                switch (typeFile)
                {
                    case "Text":
                        textList.Add(splitStr[i]);
                        break;
                    case "Image":
                        imageList.Add(splitStr[i]);
                        break;
                    case "Movie":
                        movieList.Add(splitStr[i]);
                        break;
                }
                i++;
            }
            TextFiles[] textArr = textFiles.SplitParts(textList);
            TextFiles[] textArrSort = textFiles.SortSize(textArr);
            Movies[] movieArr = movies.SplitParts(movieList);
            Images[] imageArr = images.SplitParts(imageList);
            textFiles.Print(textArrSort);
            movies.Print(movieArr);
            images.Print(imageArr);
        }
        public string[] SplitString(string text)
        {
            string[] splitStr = text.Split('\n');
            return splitStr;
        }
    }
}
