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
            generator.Add(dateTime);
            generator.Add(sum);

            for (int i = 1; i <=20 ; i++)
            {
                try
                {
                    Console.Clear();

                    generator.GetRandomInt();

                    //dateTime.Update();
                    //sum.Update();

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
