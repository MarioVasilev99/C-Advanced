namespace ClubParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int hallCapacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> reservations = new Stack<string>(input);
            var halls = new Queue<Hall>();

            string currentHall = string.Empty;

            while (reservations.Any())
            {
                string currentReservation = reservations.Peek();
                bool isDigit = int.TryParse(currentReservation, out int placesReserved);

                if (isDigit == false)
                {
                    string newHallName = currentReservation;
                    var newHall = new Hall(newHallName, hallCapacity);
                    halls.Enqueue(newHall);
                    reservations.Pop();
                }
                else if (halls.Any() == false)
                {
                    reservations.Pop();
                    continue;
                }
                else
                {
                    var hall = halls.Peek();

                    if (hall.Capacity - placesReserved >= 0)
                    {
                        hall.Capacity -= placesReserved;
                        hall.Reservations.Add(placesReserved);
                        reservations.Pop();
                    }
                    else
                    {
                        Console.WriteLine($"{hall.Name} -> {string.Join(", ", hall.Reservations)}");
                        halls.Dequeue();
                    }
                }
            }
        }

        public class Hall
        {
            public Hall(string name, int maxCapacity)
            {
                this.Name = name;
                this.Capacity = maxCapacity;
                this.Reservations = new List<int>();
            }

            public string Name { get; set; }

            public int Capacity { get; set; }

            public List<int> Reservations { get; set; }
        }
    }
}
