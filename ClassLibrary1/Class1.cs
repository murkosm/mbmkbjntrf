using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
       public static string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consulationTime)
        {
            if(beginWorkingTime > endWorkingTime || consulationTime <= 0)
            {
                return null;
            }
            List<TimeSpan>  periods = new List<TimeSpan>();
            int i = 0;
            foreach(var item in startTimes)
            {
                if( item < beginWorkingTime)
                {
                    i++;
                }
              
            }
            while(beginWorkingTime.Add(new TimeSpan(0, consulationTime, 0)) <= endWorkingTime)
            {
                if( startTimes.Length != i && durations.Length !=i)
                {
                   if (beginWorkingTime.Add(new TimeSpan(0, consulationTime,0)) > startTimes[i])
                    {
                        beginWorkingTime = startTimes[i].Add(new TimeSpan(0, durations[i], 0));
                        i++;
                        continue;

                    }
                }
                periods.Add(beginWorkingTime);
                beginWorkingTime = beginWorkingTime.Add(new TimeSpan(0, consulationTime, 0));
            }
            List<string> strings = new List<string>();
            foreach( TimeSpan item in periods)
            {
                strings.Add(item.ToString(@"hh\:mm") + "-" + item.Add(new TimeSpan(0, consulationTime, 0)).ToString(@"hh\:mm"));
            }
            return strings.ToArray();
        }
        

        


    }

}
