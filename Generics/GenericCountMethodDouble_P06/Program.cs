namespace P05.GenericCountMethod
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<double> listOfData = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double data = double.Parse(Console.ReadLine());

                listOfData.Add(data);
            }

            double element = double.Parse(Console.ReadLine());

            int count = GetCountOfGreaterElements<double>(listOfData, element);

            Console.WriteLine(count);
        }

        public static int GetCountOfGreaterElements<T>(List<T> listOfData, T element)
            where T : IComparable
        {
            int countOfGreaterElements = 0;

            foreach (var item in listOfData)
            {
                if (item.CompareTo(element) > 0)
                {
                    countOfGreaterElements++;
                }
            }

            return countOfGreaterElements;
        }
    }
}
