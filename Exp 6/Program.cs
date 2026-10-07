using System;
using System.Threading;

class ThreadDemo
{
    static AutoResetEvent mainTurn = new AutoResetEvent(true);
    static AutoResetEvent childTurn = new AutoResetEvent(false);

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            childTurn.WaitOne();

            Console.WriteLine("Child Thread : " + i);

            mainTurn.Set();
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(PrintNumbers);

        t1.Start();

        for (int i = 1; i <= 5; i++)
        {
            mainTurn.WaitOne();

            Console.WriteLine("Main Thread : " + i);

            childTurn.Set();
        }

        t1.Join();

        Console.WriteLine("Execution Completed.");
    }
}