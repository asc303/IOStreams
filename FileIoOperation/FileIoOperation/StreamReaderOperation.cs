using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIoOperation
{
    class StreamReaderOperation
    {
        public static void WriteUsingStreamWriter() 
        {
            string path = @"D:\git project\IOStreams\FileIoOperation\FileIoOperation\Example.txt";
            using (StreamWriter sr = File.AppendText(path)) 
            {
                sr.WriteLine("Hello World- .Net is Awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        public static void ReadFromStreamReader() 
        {
            string path = @"D:\git project\IOStreams\FileIoOperation\FileIoOperation\Example.txt";
            using (StreamReader sr = File.OpenText(path)) 
            {
                string s = "";
                while ((s= sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
