using System;
using System.ComponentModel;

namespace string_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please inter string:");
        
            string content = Console.ReadLine();
            string contentSpace = content.Replace(" ", "_");
            string contentLeading = content.TrimStart();
            string contentTraling = content.TrimEnd();
            string Replace = content.Replace("a", "A");
            Console.WriteLine($"{content }\n,{contentSpace}\n,{contentLeading}\n,{contentTraling}\n,{Replace}\n");
                }
    }
}
