using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Text: file.txt(6B); Some string content
            Image: img.bmp(19MB); 1920х1080
            Text:data.txt(12B); Another string
            Text:data1.txt(7B); Yet another string
            Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";

            My_List textList = new My_List();
            My_List imageList = new My_List();
            My_List movieList = new My_List();
            TextFile textF = new TextFile();
            My_List size = new My_List();

            string[] split = text.Split('\n');
            StructFiles(split, textList, imageList, movieList, size);
            My_List textListSort = textF.SortSize(size, textList);
            Print<TextFile>(textListSort, "Text files");
            Print<Movie>(movieList, "Movies");
            Print<Image>(imageList, "Images");
            
            Console.ReadLine();
        }
        public static My_List StructFiles(string[] splitStr, My_List textList, My_List imageList, My_List movieList, My_List size)
        {
            for (int i = 0;  i < splitStr.Length; i++)
            {
                string[] fileName = splitStr[i].Split(':');
                string typeFile = fileName[0].Trim();
                switch (typeFile)
                {
                    case "Text":
                        TextFile textFiles = new TextFile();
                        textFiles.SplitStr(fileName[1], ref size);
                        textList.Add(textFiles);
                        break;
                    case "Image":
                        Image images = new Image();
                        images.SplitStr(fileName[1]);
                        imageList.Add(images);
                        break;
                    case "Movie":
                        Movie movies = new Movie();
                        movies.SplitStr(fileName[1]);
                        movieList.Add(movies);      
                        break;
                }
            }
            return size;
        }
        public static void Print<T>(My_List files, string typeFile) where T : File
        {
            Console.WriteLine(typeFile);
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i] is T file)
                {
                    file.Print();
                }
            }
        }
    }
}
