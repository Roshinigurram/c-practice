using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    public class cb
    {
        public void cc() {
            List<string> s = new List<string>();
            s.Add("hi");
            s.Add("hello");
            s.Add("welcome");
            s.Add("to");
            List<int> p = new List<int>();
            p.Add(1);
            p.Add(2);
            p.Add(3);
            p.Add(4);
            p.Add(5);
            ConcurrentBag<string> ss = new ConcurrentBag<string>(s);
            ConcurrentBag<int> pp = new ConcurrentBag<int>(p);
            Parallel.For(0, ss.Count, i =>
            {
                Console.WriteLine(s[i]);
            });
            Parallel.ForEach(pp, d =>
            {
                Console.WriteLine(d);
            });
        }
    }
}
