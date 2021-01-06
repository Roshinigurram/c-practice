using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
   public class slist
    {
        public void sl()
        {
            SortedList<int, string> s = new SortedList<int, string>();
            s.Add(1, "lakshmi");
            s.Add(2, "pavani");
            s.Add(3, "milky");
            s.Add(4, "gujju");
            Parallel.ForEach(s, i =>
            {
               Console.WriteLine(i);
            });
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
