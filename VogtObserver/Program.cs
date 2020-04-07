using System;
using System.Threading;

namespace VogtObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();
            Date dateTime = new Date();
            Sum sum = new Sum();
            generator.Add(dateTime);
            generator.Add(sum);

            Run(generator, dateTime, sum);
        }

        public static void Run(RandomNumberGenerator generator, Date dateTime, Sum sum)
        {

            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                generator.ChangeToRandomNumber();
                Thread.Sleep(2000);
            }


        }
    }
}
