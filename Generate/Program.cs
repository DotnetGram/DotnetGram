
using System;
using System.IO;

namespace Generate 
{
    class Program
    {
        static void Main(string[] args)
        {
            TypesConvert.Convert(File.ReadAllText("api.json"));
        }
    }
}


