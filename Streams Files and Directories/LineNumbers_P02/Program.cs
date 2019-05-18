namespace LineNumbers_P02
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
                    var punctuationMarks = new List<char>
                    {
                        '.', '-', '?', '!', ',', '\''
                    };

                    int counter = 1;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        // COUNT PUNCTUATION MARKS AND CHARACTERS
                        int charsCount = 0;
                        int punctMarksCount = 0;

                        foreach (char symbol in line)
                        {
                            if (punctuationMarks.Contains(symbol))
                            {
                                punctMarksCount++;
                            }
                            else if (symbol != ' ')
                            {
                                charsCount++;
                            }
                        }

                        // ADD LINE NUMBERS AND WRITE
                        string lineToWrite = $"Line {counter}: {line}({charsCount})({punctMarksCount})";

                        if (counter != 1)
                        {
                            writer.WriteLine();
                        }

                        writer.Write(lineToWrite);

                        counter++;
                    }
                }
            }
        }
    }
}
