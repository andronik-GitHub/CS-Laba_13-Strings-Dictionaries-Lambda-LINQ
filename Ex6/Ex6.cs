using System;
using System.Collections.Generic;

class Ex6
{
    static void Main()
    {
        string? sentence = Console.ReadLine();
        Console.WriteLine();


        if (sentence != null)
        {
            string[] temp = sentence.Split('.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ');
            List<string> words = new();
            List<string> characters = new();


            foreach (string item in temp)
                if (item.Length > 0) words.Add(item);

            for (int i = 0; i < words.Count - 1; i++)
            {
                Console.WriteLine(sentence.IndexOf(words[i]) + words[i].Length);
                Console.WriteLine(sentence.IndexOf(words[i + 1]));
                Console.WriteLine();

                try
                {
                    characters.Add
                        (
                            sentence.Substring
                            (
                                sentence.IndexOf(words[i]) + words[i].Length,
                                sentence.IndexOf(words[i + 1])
                            )
                        );
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n");
                }
            }

            foreach (string item in characters)
                Console.WriteLine(item);
        }


        Console.ReadKey();
    }
}