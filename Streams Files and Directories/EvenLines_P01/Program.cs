namespace EvenLines_P01
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                using (var writer = new StreamWriter(@"../../../output.txt"))
                {
                    int counter = 0;

                    var charactersToReplace = new List<char>
                    {
                        '-', ',', '.', '!', '?'
                    };

                    string currentLine = reader.ReadLine();

                    while (currentLine != null)
                    {
                        string changedLine = string.Empty;

                        if (counter % 2 == 0)
                        {
                            if (counter != 0)
                            {
                                writer.WriteLine();
                            }

                            for (int i = 0; i < currentLine.Length; i++)
                            {
                                char currentSymbol = currentLine[i];

                                if (charactersToReplace.Contains(currentSymbol))
                                {
                                    changedLine += '@';
                                }
                                else
                                {
                                    changedLine += currentSymbol;
                                }
                            }

                            string[] splittedLine = changedLine.Split(" ");
                            Array.Reverse(splittedLine);

                            writer.Write($"{string.Join(" ", splittedLine)}");
                        }
                        currentLine = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
