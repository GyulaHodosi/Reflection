using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceProcess.dll";

            // Using BindingFlags to only get declared and instance members
            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

            // Load the Assembly from the path
            Assembly assembly = Assembly.LoadFrom(path);
            Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes();

            foreach (Type t in types)
            {
                Console.WriteLine(" Type: {0}", t.Name);
                MemberInfo[] members = t.GetMembers(flags);

                foreach (MemberInfo member in members)
                {
                    Console.WriteLine(" {0}: {1}", member.MemberType, member.Name);
                }
            }
            Console.ReadLine(); 
        }
    }
}
