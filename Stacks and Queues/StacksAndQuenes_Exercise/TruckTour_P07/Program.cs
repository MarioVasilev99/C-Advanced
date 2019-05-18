namespace TruckTour_P07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int petrolStationsCount = int.Parse(Console.ReadLine());

            Queue<int> stationsDifference = new Queue<int>();

            for (int i = 0; i < petrolStationsCount; i++)
            {
                int[] stationInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int difference = stationInfo[0] - stationInfo[1];
                stationsDifference.Enqueue(difference);
            }
            
            int index = 0;

            while (true)
            {
                Queue<int> copyStationsDiff = new Queue<int>(stationsDifference);

                int fuel = -1;

                while (copyStationsDiff.Any())
                {
                    if (copyStationsDiff.Peek() < 0 && fuel == -1)
                    {
                        copyStationsDiff.Enqueue(copyStationsDiff.Dequeue());
                        stationsDifference.Enqueue(stationsDifference.Dequeue());

                        index++;
                    }
                    else if (copyStationsDiff.Peek() > 0 && fuel == -1)
                    {
                        fuel = copyStationsDiff.Dequeue();

                        stationsDifference.Enqueue(stationsDifference.Dequeue());
                    }
                    else
                    {
                        fuel += copyStationsDiff.Dequeue();
                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }
                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                index++;
            }
        }
    }
}
