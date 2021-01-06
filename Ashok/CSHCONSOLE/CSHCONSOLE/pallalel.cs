using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    public class pallalel
    {

        public static void paralel()
        {

            Thread t1 = new Thread(fun);
            Thread t2 = new Thread(fun);
            Thread t3 = new Thread(fun);
            t1.Start();
            
            t2.Start();
            t3.Start();
            fun();

            ParallelOptions p = new ParallelOptions();
            p.MaxDegreeOfParallelism = 3;
        }
        static Object Lock = new Object();  
       
          
        static void fun()
        {
            lock (Lock)
            {
                for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread"+i);
            }
        }
    }
    }
    } 


