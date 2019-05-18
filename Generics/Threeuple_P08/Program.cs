namespace P07.Tuple
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] personTupleData = Console.ReadLine().Split(" ");

            string name = $"{personTupleData[0]} {personTupleData[1]}";
            string personAdress = personTupleData[2];
            string personTown = personTupleData[3];

            var personTuple = new Tuple<string, string, string>(name, personAdress, personTown);

            string[] personBeerData = Console.ReadLine().Split(" ");

            string personName = personBeerData[0];
            int beerAbleToDrink = int.Parse(personBeerData[1]);

            bool drunkOrNot = false;

            if (personBeerData[2] == "drunk")
            {
                drunkOrNot = true;
            }

            var personBeerTuple = new Tuple<string, int, bool>(personName, beerAbleToDrink, drunkOrNot);

            string[] personBankAccountData = Console.ReadLine().Split(" ");

            string nameOfPerson = personBankAccountData[0];
            double accountBalance = double.Parse(personBankAccountData[1]);
            string bankName = personBankAccountData[2];

            var bankTuple = new Tuple<string, double, string>(nameOfPerson, accountBalance, bankName);

            Console.WriteLine(personTuple);
            Console.WriteLine(personBeerTuple);
            Console.WriteLine(bankTuple);
        }
    }
}
