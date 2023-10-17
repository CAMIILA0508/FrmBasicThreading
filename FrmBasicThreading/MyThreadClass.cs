using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBasicThreading
{
    internal class MyThreadClass
    {
        public void thread1()
    {
            for (int LoopCount = 0; LoopCount <= 2; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread : " + thread.Name + "=" + LoopCount);
                Thread.Sleep(TimeSpan.FromSeconds(0.5));

            }
        }
        public void thread2()
        {
            for (int LoopCount = 0; LoopCount <= 2; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread : " + thread.Name + "=" + LoopCount);
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
            }
        }
    }
}
