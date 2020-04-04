using System;
using System.Threading;

namespace VogtObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();
            Date dateTime = new Date(generator);
            Sum sum = new Sum(generator);

            Run(generator, dateTime, sum);
        }

        public static void Run(RandomNumberGenerator generator, Date dateTime, Sum sum)
        {

            dateTime = new Date(generator);
            sum = new Sum(generator);

            Console.Clear();
            generator.GetRandomInt();
            Thread.Sleep(2000);

            for (int i = 1; i <=1 ; i++)
            {
                try
                {

                }
                catch
                {
                    Console.WriteLine("Error!");
                }

            }
        }
    }
}
