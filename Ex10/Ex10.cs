using System;

class Ex10
{
    static void Main()
    {
        string? word = Console.ReadLine(); // слово

        if (word != null)
        {
            int index = 0;

            for (int i = 0; i < word.Length / 2; i++) // перевірча чи слово вже паліндром
                if (word[i] == word[word.Length - i - 1])
                    index++;

            if (index == word.Length / 2) Console.WriteLine("-1"); // якщо слово вже паліндром
            else // якщо слово не паліндром
            {
                for (int i = 0; i < word.Length; i++) // і - символ який пропускається
                {
                    for (int j = 0; j < word.Length; j++) // перевірка на паліндром без і-го символа
                        if (word[j] == word[word.Length - j - 1] && i != j)
                            index++;

                    if (index == word.Length / 2) // якщо паліндром
                    {
                        Console.WriteLine(i); // виводиться пропущений символ
                        break;
                    }
                    else index = 0; // якщо не паліндром індекс онулюється
                }

            }
        }


        Console.ReadKey();
    }
}