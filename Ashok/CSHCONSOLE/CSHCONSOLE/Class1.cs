using System;
using System.Collections.Generic;
using System.Text;

namespace CSHCONSOLE
{
    public class Class1
    {
        public void ll(params object[] p)
        {
            //int sum = 0;
            foreach (var n in p)
            {
                Console.WriteLine(n);
            }
            
        }
        
}
}
