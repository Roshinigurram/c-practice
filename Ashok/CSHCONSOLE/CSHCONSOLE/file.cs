using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSHCONSOLE
{
    public class file
    {
        public static void f()
        {
            Console.WriteLine("enter the file name");
            var name = Console.ReadLine();
            Console.WriteLine("enter the contents in the file");
            var content = Console.ReadLine();
            var path = Path.Combine(Environment.CurrentDirectory, name);
            using (FileStream fs = File.Create(path))
            {
                using (TextWriter writer = new StreamWriter(fs))
                {
                    Console.WriteLine(content);
                }
            }
            File.WriteAllText(path, content);
            var c = File.ReadAllText(name);
            Console.WriteLine(c);
        }
        }
}
