namespace P07.Tuple
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] personTupleData = Console.ReadLine().Split(" ");

            string name = $"{personTupleData[0]} {personTupleData[1]}";
            string personTown = personTupleData[2];

            Tuple<string, string> personTuple = new Tuple<string, string>(name, personTown);

            string[] personBeerData = Console.ReadLine().Split(" ");

            string personName = personBeerData[0];
            int beerAbleToDrink = int.Parse(personBeerData[1]);

            Tuple<string, int> personBeerTuple = new Tuple<string, int>(personName, beerAbleToDrink);

            string[] personDrinkedBeerData = Console.ReadLine().Split(" ");

            int intData = int.Parse(personDrinkedBeerData[0]);
            double doubleData = double.Parse(personDrinkedBeerData[1]);

            Tuple<int, double> newTuple = new Tuple<int, double>(intData, doubleData);

            Console.WriteLine(personTuple);
            Console.WriteLine(personBeerTuple);
            Console.WriteLine(newTuple);
        }
    }
}
