using System;
using System.Reflection;

namespace CAReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\Youya\\Desktop\\MOE.dll";
            // var path = @"C:\Users\Youya\Desktop\MOE.dll";
            var assembly = Assembly.LoadFile(path);
            var types = assembly.GetTypes();
            foreach (var t in types)
            {
                Console.WriteLine(t);
            }
            Console.ReadKey();
        }
    } 
}
