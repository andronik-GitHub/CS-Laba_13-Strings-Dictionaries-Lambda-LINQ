using System;
using System.Linq;

class Ex8
{
    static void Main()
    {
        string? sentence = Console.ReadLine(); // строка

        if (sentence != null)
        {
            string[] words = sentence.Split(' ', ',', '.', '?', '!'); // розбивається на слова

            List<string> palindromes = new(); // для паліндромів

            foreach (string word in words) // проходиться по словам
            {
                int index = 0;
                for (int i = 0; i < word.Length / 2; i++)
                    if (word[i] == word[word.Length - i - 1]) // якщо і-ий і і-ий з кінця однакові
                        index++;

                if (index == word.Length / 2 && word.Length > 0) // якщо index == половині слова
                {
                    for (int j = 0; j < palindromes.Count; j++) // чи записаний вже такий паліндром
                        if (word == palindromes[j])
                        {
                            index = -1;
                            break;
                        }

                    if (index != -1) // чи записаний вже такий паліндром
                        palindromes.Add(word); // слово додається до паліндромів}
                }
            }

            palindromes.Sort(); // сортирується
            Console.WriteLine(string.Join(", ", palindromes)); // виводяться всі паліндроми
        }

        
        Console.ReadKey();
    }
}