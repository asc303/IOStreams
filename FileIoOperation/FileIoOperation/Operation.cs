using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIoOperation
{
    class Operation
    {
        public static void FileExists() 
        {
            string path = @"D:\git project\IOStreams\FileIoOperation\FileIoOperation\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public static void ReadAllLines() 
        {
            string path = @"D:\git project\IOStreams\FileIoOperation\FileIoOperation\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void FIleCopy() 
        {
            string path = @"D:\git project\IOStreams\FileIoOperation\FileIoOperation\Example.txt";
            string copyPath = @"D:\git project\IOStreams\FileIoOperation\FileIoOperation\ExampleNew.txt";
            File.Copy(path, copyPath);
            Console.ReadKey();
        }
        public static void FileDelete() 
        {
            string path = @"D:\git project\IOStreams\FileIoOperation\FileIoOperation\ExampleNew.txt";
            File.Delete(path);
            Console.ReadKey();
        }
    }
}
