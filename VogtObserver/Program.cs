using System;
using System.Threading;

namespace VogtObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            Date dateTime = new Date(generator);
            Sum sum = new Sum(generator);

            Run(generator, dateTime, sum);
        }

        public static void Run(Generator generator, Date dateTime, Sum sum)
        {
            for (int i = 1; i <=20 ; i++)
            {
                try
                {
                    Console.Clear();
                    generator.GetRandomInt();
                    dateTime.Update();
                    sum.Update();
                    Thread.Sleep(2000);
                }
                catch
                {
                    Console.WriteLine("Error!");
                }

            }
        }
    }
}
