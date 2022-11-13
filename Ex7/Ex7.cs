using System;

class Ex7
{
    static void Main()
    {
        string? sentence = Console.ReadLine(); // речення

        if (sentence != null)
        {
            List<string> newSentece = new(); // для підстрок між <upcase> </upcase>
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i + 7 < sentence.Length)
                    if (sentence[i] == '<' &&
                        sentence[i + 1] == 'u' &&
                        sentence[i + 2] == 'p' &&
                        sentence[i + 3] == 'c' &&
                        sentence[i + 4] == 'a' &&
                        sentence[i + 5] == 's' &&
                        sentence[i + 6] == 'e' &&
                        sentence[i + 7] == '>') // якщо знайдено <upcase>
                    {
                        string temp = ""; // символи до </upcase>
                        for (int j = i + 8; j < sentence.Length; j++)
                        {
                            temp += sentence[j];

                            if (i + 9 < sentence.Length)
                                if (sentence[j + 1] == '<' &&
                                    sentence[j + 2] == '/' &&
                                    sentence[j + 3] == 'u' &&
                                    sentence[j + 4] == 'p' &&
                                    sentence[j + 5] == 'c' &&
                                    sentence[j + 6] == 'a' &&
                                    sentence[j + 7] == 's' &&
                                    sentence[j + 8] == 'e' &&
                                    sentence[j + 9] == '>') { i = j; break; } // якщо знайдено </upcase>
                        }
                        newSentece.Add(temp); // додається підстрока
                    }
            }
            foreach (string temp in newSentece) // заміна підстрок в верхній регістр
                if (sentence.Contains(temp)) // якщо підстрока є в реченні
                    sentence = sentence.Replace(temp, temp.ToUpper()); // замінюється на верхній регістер

            sentence = sentence.Replace("<upcase>", ""); // видалення <upcase>
            sentence = sentence.Replace("</upcase>", ""); // видалення </upcase>

            Console.WriteLine(sentence); // виводиться нове речення
        }


        Console.ReadKey();
    }
}