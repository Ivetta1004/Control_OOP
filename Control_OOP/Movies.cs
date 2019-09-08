using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class Movies : Images
    {
        protected string Length;

        public new Movies[] SplitParts(My_List<string> movieList)
        {
            Movies[] movieArr = new Movies[movieList.Count];
            for (int x = 0; x < movieArr.Length; x++)
            {
                movieArr[x] = new Movies();
            }
            for (int i = 0; i < movieList.Count; i++)
            {
                if (movieList[i] != null)
                {
                    movieArr[i].NameFile = movieList[i].Split(':')[1].Split('(')[0];
                    movieArr[i].Extension = movieArr[i].NameFile.Split('.')[2].Split('(')[0];
                    movieArr[i].Size = movieList[i].Split('(')[1].Split(')')[0];
                    movieArr[i].Resolution = movieList[i].Split(';')[1];
                    movieArr[i].Length = movieList[i].Split(';')[2];
                }
            }
            return movieArr;
        }
        public void Print(Movies[] movieArr)
        {
            Console.WriteLine("Movies:");
            for (int i = 0; i < movieArr.Length; i++)
            {
                Console.WriteLine($"\t{movieArr[i].NameFile}\n \t\tExtension: {movieArr[i].Extension}\n" +
                    $" \t\tSize: {movieArr[i].Size}\n" +
                    $" \t\tResolution: {movieArr[i].Resolution}\n" +
                    $" \t\tLength: {movieArr[i].Length}");
            }
        }
    }
}
