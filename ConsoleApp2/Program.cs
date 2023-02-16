using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            int consultationTime = 30;
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            TimeSpan consultation = new TimeSpan(0, consultationTime, 0);

            while (beginWorkingTime < endWorkingTime)
            {
                int j = 0;

                //startTimes[j] += consultation;


                TimeSpan newconsultation = beginWorkingTime + consultation;
                strings.Add($"{beginWorkingTime}-{newconsultation}");

                beginWorkingTime = newconsultation;

            }


            Console.WriteLine( strings.ToArray());
            Console.ReadKey();
        }
    }
}
