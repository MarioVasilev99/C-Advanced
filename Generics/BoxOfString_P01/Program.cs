namespace BoxOfString_P01
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();

                Box<string> box = new Box<string>(value);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
