using System;

class Ex9
{
    static void Main()
    {
        string? sentence = Console.ReadLine(); // строка

        if (sentence != null)
        {
            string[] words = sentence.Split(' ', '.', ',', '?', '!', ';'); // розбивається на слова

            foreach (string word in words) // проходиться по словам
            {
                string FirstLetterUpCase = ""; // для оновленого слова
                for (int i = 0; i < word.Length; i++) // проходиться по слову
                {
                    FirstLetterUpCase += word[i]; // посимвольно записуєтсья слово
                    if (i == 0) FirstLetterUpCase = FirstLetterUpCase.ToUpper(); // якщо 1-й символ то переводить в верхній регістер
                }

                sentence = sentence.Replace(word, FirstLetterUpCase); // заміна слова на нове
            }

            Console.WriteLine(sentence); // виводиться оновлена строка
        }


        Console.ReadKey();
    }
}