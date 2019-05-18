namespace DateModifier_P05
{
    using System;

    public class Program
    {
        public static void Main()
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            double differenceInDays = Math.Abs((firstDate - secondDate).TotalDays);

            Console.WriteLine(differenceInDays);
        }
    }
}
