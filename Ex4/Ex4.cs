using System;

class Ex4
{
    static void Main()
    {
        string? Word = Console.ReadLine();
        string[]? Text = Console.ReadLine()?.Split('.', '!', '?'); // зчитується розбирий на підстроки текст


        if (Word != null && Text != null)
        {
            List<string> NewText = new(); // для шуканих строк

            for (int i = 0; i < Text.Length; i++) // проходиться по зчитаному тексту
                if (Text[i].Contains(Word)) // чи міститься шукане слова в підстроці
                {
                    string[] Temp = Text[i].Split(' ', '-', '_', ','); // підстрока розбивається на слова

                    if (Temp.Contains(Word)) // якщо серед слів є шукане
                        NewText.Add(Text[i].Trim()); // зберігається підстрока
                }

            Console.WriteLine();
            foreach (string s in NewText) // строки з шуканим словом
                Console.WriteLine(s);
        }



        Console.ReadKey();
    }
}