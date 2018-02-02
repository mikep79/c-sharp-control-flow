using System;
using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace c_sharp_control_flow
{
    class FileDirPathExercises
    {
        public static void Exercise1()
        {
            //1- Write a program that reads a text file and displays the number of words.
            // create a file, append text. or use desktop file.
            // call readall text method.
            // split(' ') into array
            //display array length
            var path = @"c:\users\mike\desktop\test_file22.rtf";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists - deleting");
                File.Delete(path);
            }
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Here is some text");
                    sw.Close();
                }
                var fileText = File.ReadAllText(path);
                String[] textArray = fileText.Split(' ');
                foreach (var word in textArray)
                    Console.WriteLine(word);
                Console.WriteLine("Number of words: " + textArray.Length);
                File.Delete(path);
            }
        }
    }
}
