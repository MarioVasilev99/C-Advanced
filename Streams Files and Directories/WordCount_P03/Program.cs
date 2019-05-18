namespace WordCount_P03
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Word
    {
        public Word(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int TimesFound { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // READ WORDS
            var words = new List<Word>();

            using (var reader = new StreamReader(@"../../../words.txt"))
            {
                while (true)
                {
                    string currentWord = reader.ReadLine();

                    if (currentWord == null)
                    {
                        break;
                    }

                    var newWord = new Word(currentWord);

                    words.Add(newWord);
                }
            }

            // READ TEXT AND COUNT OCCURENCES OF WORDS -> THEN WRITE TO actualResult.txt
            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                using (var writer = new StreamWriter(@"../../../actualResult.txt"))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        string[] splittedLine = line
                        .Split(new char[] { ' ', ',', '.', '?', '!', '-' },
                            StringSplitOptions.RemoveEmptyEntries);

                        // COUNT OCCURENCIES
                        foreach (var word in words)
                        {
                            foreach (var item in splittedLine)
                            {
                                if (item.ToLower() == word.Name)
                                {
                                    word.timesFound++;
                                }
                            }
                        }
                    }

                    // WRITE TO actualResult.txt
                    int lineCounter = 0;

                    foreach (var word in words.OrderByDescending(w => w.TimesFound))
                    {
                        string lineToWrite = $"{word.Name} - {word.TimesFound}";

                        if (lineCounter != 0)
                        {
                            writer.WriteLine();
                        }

                        writer.Write(lineToWrite);

                        lineCounter++;
                    }
                }
            }
        }
    }
}
