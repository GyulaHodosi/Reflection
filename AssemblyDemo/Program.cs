using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll";
            Assembly assembly = Assembly.LoadFile(path);
            ShowAssembly(assembly);
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            ShowAssembly(myAssembly);
            Console.ReadLine();
        }

        private static void ShowAssembly(Assembly assembly)
        {
            Console.WriteLine($"Fullname: {assembly.FullName}\nGlobalAssembly Cache: {assembly.GlobalAssemblyCache}\nLocation: {assembly.Location}\nImageRuntimeVersion: {assembly.ImageRuntimeVersion}");
            foreach (var module in assembly.Modules)
            {
                Console.WriteLine($"Module:{0}, {module.Name}");
            }
            Console.WriteLine();
        }
    }
}
