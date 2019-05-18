namespace P05.GenericCountMethod
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> listOfData = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();

                listOfData.Add(data);
            }

            string element = Console.ReadLine();

            int count = GetCountOfGreaterElements<string>(listOfData, element);

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
