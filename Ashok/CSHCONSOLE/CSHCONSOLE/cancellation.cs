using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
   public class cancellation
    {
        public static void sss()
        {
            IList<string> can = new List<string>();
            for(var i = 0; i < 1000; i++)
            {
                can.Add("invoices"+i);
            }
            DateTime o = DateTime.Now;
            ParallelOptions po = new ParallelOptions();
            po.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
            Parallel.For(0, can.Count, i =>
              {
                  Console.WriteLine(can[i]);
              });
            DateTime p = DateTime.Now;
            Console.WriteLine(p-o);
            CancellationTokenSource cts = new CancellationTokenSource();
            ParallelOptions a = new ParallelOptions();
            a.MaxDegreeOfParallelism = System.Environment.ProcessorCount - 1;
            a.CancellationToken = cts.Token;
            Console.WriteLine("press  any key to stop ");
            Console.ReadKey();
            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar == 'c')
                {
                    cts.Cancel();
                }
            });
            try
            {
                Parallel.ForEach(can,po,g=>
                    {
                        Console.WriteLine(can);
                        po.CancellationToken.ThrowIfCancellationRequested();
                });
            }
            catch(OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            DateTime d = DateTime.Now;
            Console.WriteLine(p-o);
        }
    }
}
