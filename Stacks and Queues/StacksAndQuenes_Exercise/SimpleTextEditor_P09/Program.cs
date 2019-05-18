namespace SimpleTextEditor_P09
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> versions = new Stack<string>();

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] userInput = Console.ReadLine().Split();

                int command = int.Parse(userInput[0]);

                if (command == 1)
                {
                    versions.Push(text.ToString());

                    string textToAppend = userInput[1];

                    text.Append(textToAppend);
                }
                else if (command == 2)
                {
                    versions.Push(text.ToString());
                    
                    if (text.Length == 0)
                    {
                        continue;
                    }

                    int elementsToRemove = Math.Min(int.Parse(userInput[1]), text.Length);
                    int removeStartIndex = Math.Max(text.Length - elementsToRemove, 0);

                    text.Remove(removeStartIndex, elementsToRemove);
                }
                else if (command == 3)
                {
                    int indexToSearch = int.Parse(userInput[1]) - 1;

                    char[] textAsArray = text.ToString().ToCharArray();
                    char element = textAsArray[indexToSearch];

                    Console.WriteLine(element);
                }
                else if (command == 4)
                {
                    text.Clear();

                    string previousVersion = versions.Pop();
                    text.Append(previousVersion);
                }
            }
        }
    }
}
