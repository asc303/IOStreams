using System;

namespace FileIoOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation.FileExists();
            Operation.ReadAllLines();
            Operation.FIleCopy();
            Operation.FileDelete();
            StreamReaderOperation.ReadFromStreamReader();
            StreamReaderOperation.WriteUsingStreamWriter();
        }
    }
}
