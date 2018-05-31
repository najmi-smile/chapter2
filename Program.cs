using System;
using System.Linq;
using System.Reflection;

namespace chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));
                int methodCount = 0;
                foreach(var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }
                Console.WriteLine($"{a.DefinedTypes.Count() :N0} types " + $"with {methodCount :N0} methods in {r.Name} assembly.");
            }
        }
    }
}
