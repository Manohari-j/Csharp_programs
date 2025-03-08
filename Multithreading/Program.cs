namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //thread:An execution path of a program.
            //multiple threads to perform diff tasks of our program at the same time.
            //current thread running is main thread. Using System.Threading


            Thread mainThread  = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread t1 = new Thread(() => CountDown("Timer #1"));
            Thread t2 = new Thread(() => CountUp("Timer #2"));

            t1.Start();
            t2.Start();

            // CountDown();
            //CountUp();

            Console.WriteLine(mainThread.Name + " is complete!");
            

            Console.ReadKey();
        }

        public static void CountUp(String name)
        {
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(name +" "+ i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
        public static void CountDown(String name)
        {
            for (int i = 10; i >=0; i--)
            {
                Console.WriteLine(name + " " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
    }
}
