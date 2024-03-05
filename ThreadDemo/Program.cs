using System;


class Program
{
    static void Main()
    {
        Thread t1 = new Thread(Numbers);
        Thread t2 = new Thread(NumbersAfter10);
        t1.Start();
        //t1.Join();

        //for(int i = 0; i < 5; i++)
        //{
        //    //Console.WriteLine(i);
        //    Console.WriteLine("main thread " + i);
        //    Thread.Sleep(1000);
        //}
        // t1.Join();
        
        Console.WriteLine("main thread finished");
        Thread.Sleep(1000);
        t1.Join();
        t2.Start();
    }
    public static void Numbers()
    {
        for(int i=1;i<5;i++)
        {
            Console.WriteLine("method thread " +i);
        }
        
        Console.WriteLine("method completed");

    }

    public static void NumbersAfter10()
    {
        for(int i = 11; i < 15; i++)
        {
            Console.WriteLine("method thread " + i);
        }
    }

}
