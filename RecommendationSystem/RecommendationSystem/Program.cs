using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> userPreferences = new Dictionary<int, int>();

            string line = "";
            using (StreamReader writer = new StreamReader(@"C:\Users\Johan\Desktop\INFDTA01-1\userItem.data"))
            {
                while ((line = writer.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();

            //{
            //    foreach (var line in File.ReadLines(filename))
            //    {
            //        foreach (var num in line.Split(','))
            //        {
            //            writer.Write(num + " ");
            //        }
            //    }
            //}

            




            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Johan\Desktop\INFDTA01-1\userItem.data");

            

            //foreach (var line in file.ReadLines()
            //{
            //    foreach (var num in line.Split(','))
            //    {
            //        userPreferences.Add(int.Parse(num[0]), int.Parse(num[1]));
            //    }
            //}

            //foreach (DataRow row in file.Tables[0].Rows)
            //{
            //    string[] columns = line.Split(',');

            //}               

            // Read the file as one string.
            //string text = System.IO.File.ReadAllText(@"C:\Users\Johan\Desktop\INFDTA01-1\userItem.data");

            // Display the file contents to the console. Variable text is a string.
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }
    }
}
