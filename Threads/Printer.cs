using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class Printer
    {
        public void PrintNumbers()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(i + $"{Thread.CurrentThread.Name}, ");
                }
                
                Console.WriteLine();
            }
           
        }
    }
}
