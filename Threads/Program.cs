using Threads;

Console.WriteLine("======MultiThreads======");

Printer p = new Printer();
Thread[] threads = new Thread[3];

for(int i = 0; i < 3; i++)
{
    threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
    threads[i].Name = "ThreadFilha " + i;
}
foreach (Thread t in threads)
{
    t.Start();
}

Console.ReadLine();