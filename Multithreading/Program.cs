//Thread.Sleep(2000);

//await Task.Run(async () =>
//{
//    Task.Delay(2000);
//});

//var input = Console.ReadLine();

//Console.WriteLine(input);

using System.Collections.Concurrent;
using System.Threading;

object _lock = new object();

int a = 0;

//void Increment()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        lock (_lock)
//        {
//            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

//            Thread.Sleep(10000);
//            a++;
//        }
//    }
//}

//void Increment()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        Monitor.Enter(_lock);

//        try
//        {
//            a++;
//        }
//        finally
//        {
//            Monitor.Exit(_lock);
//        }
//    }
//}


//void Increment()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        mutex.WaitOne();

//        try
//        {
//            a++;
//        }
//        finally
//        {
//            mutex.ReleaseMutex();
//        }
//    }
//}

//Thread thread1 = new Thread(Increment);
//Thread thread2 = new Thread(Increment);
//thread1.Start();
//thread2.Start();

//thread1.Join();
//thread2.Join();


//Mutex mutex = new Mutex(false, "Elxan");

//void WriteToFile()
//{
//    mutex.WaitOne();

//    try
//    {
//        File.AppendAllTextAsync("C:\\Users\\mahmudov_m\\source\\repos\\Multithreading\\test.txt", $"Процесс 1 ");

//        Thread.Sleep(5000);
//    }
//    finally
//    {
//        mutex.ReleaseMutex();
//    }
//}

//WriteToFile();


//Semaphore semaphore = new Semaphore(1, 1);
//Mutex mutex = new Mutex();



//void PrintWork()
//{
//    semaphore.WaitOne();
//    try
//    {
//        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

//        Thread.Sleep(2000);
//    }
//    finally
//    {
//        semaphore.Release();
//    }
//}

//for (int i = 0; i < 20; i++)
//{
//    Thread thread = new Thread(PrintWork);
//    thread.Start();
//}

//AutoResetEvent manualResetEvent = new AutoResetEvent(false);

//Thread worker = new Thread(() =>
//{
//    Console.WriteLine("Worker is waiting");

//    manualResetEvent.WaitOne();

//    Console.WriteLine("Worker started work");
//});

//Thread worker2 = new Thread(() =>
//{
//    Thread.Sleep(3000);

//    Console.WriteLine("Worker 2 is waiting");

//    manualResetEvent.WaitOne();

//    Console.WriteLine("Worker 2 started work");
//});

//worker.Start();
//worker2.Start();

//Console.WriteLine("Main lets worker to work");

//while (true)
//{
//    Thread.Sleep(2000);
//    manualResetEvent.Set();
//}

int c = 0;
void Increment()
{
    for (int i = 0; i < 100000; i++)
    {
        Interlocked.Increment(ref c);
    }
}


Thread thread1 = new Thread(Increment);
Thread thread2 = new Thread(Increment);

thread1.Start();
thread2.Start();

thread1.Join();

Console.WriteLine(c);