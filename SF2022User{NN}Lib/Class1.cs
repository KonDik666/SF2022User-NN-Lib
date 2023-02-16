using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User_NN_Lib
{
    public class Calculations
    {
        public string[] AvailablePeriods(TimeSpan[] startTimes,
int[] durations,
TimeSpan beginWorkingTime,
TimeSpan endWorkingTime,
int consultationTime)

        {
            List<string> strings= new List<string>();

            // TimeSpan consultationTimeSpan;
            // consultationTimeSpan.Minutes = consultationTime;

            //startTimes = beginWorkingTime.Minutes + consultationTime
            TimeSpan consultation = new TimeSpan(0, consultationTime, 0);
           
            while (beginWorkingTime < endWorkingTime)
            {
                int j = 0;
                
                //startTimes[j] += consultation;


                TimeSpan newconsultation = beginWorkingTime + consultation;
                strings.Add($"{beginWorkingTime}-{newconsultation}");

                beginWorkingTime = newconsultation;

            }
            
            
            return strings.ToArray();
        }
    }
}
