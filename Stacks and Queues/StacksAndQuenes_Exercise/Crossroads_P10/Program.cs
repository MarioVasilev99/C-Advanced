namespace Crossroads_P10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> carsQueue = new Queue<string>();
            int carsPassed = 0;

            bool crashHappened = false;

            string userCommand = Console.ReadLine();

            while (userCommand != "END")
            {
                if (userCommand == "green" && carsQueue.Count > 0)
                {
                    int currentGreenLightDur = greenLightDuration;
                    int currentFreeWinDur = freeWindowDuration;

                    var carToPass = carsQueue.Peek();
                    int carLenght = carToPass.Length;
                    while (true)
                    {
                        if (currentGreenLightDur >= carLenght)
                        {
                            currentGreenLightDur -= carLenght;
                            carsPassed++;

                            carsQueue.Dequeue();

                            if (carsQueue.Any())
                            {
                                carToPass = carsQueue.Peek();
                                carLenght = carToPass.Length;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (currentGreenLightDur > 0 && carToPass.Length > currentGreenLightDur)
                        {
                            carLenght -= currentGreenLightDur;
                            currentGreenLightDur = 0;
                        }
                        else if (currentGreenLightDur == 0 & carLenght > 0)
                        {
                            int currentCarOriginalLenght = carsQueue.Peek().Length;

                            if (carLenght == currentCarOriginalLenght)
                            {
                                break;
                            }
                            carLenght -= currentFreeWinDur;

                            if (carLenght > 0)
                            {
                                string crashedCar = carsQueue.Peek();
                                int indexCrashedAt = crashedCar.Length - carLenght;

                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{crashedCar} was hit at {crashedCar[indexCrashedAt]}.");

                                crashHappened = true;
                                break;
                            }
                            else
                            {
                                carsPassed++;

                                carsQueue.Dequeue();
                                break;
                            }
                        }
                    }
                }
                else
                {
                    string carJoiningQueue = userCommand;

                    carsQueue.Enqueue(carJoiningQueue);
                }

                if (crashHappened)
                {
                    break;
                }
                else
                {
                    userCommand = Console.ReadLine();
                }
            }

            if (crashHappened == false)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}
