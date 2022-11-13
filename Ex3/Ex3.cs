using System;

class Ex3
{
    static void Main()
    {
        string? Email = Console.ReadLine();
        string? Text = Console.ReadLine();

        if (Email != null && Text != null)
        {
            string TempEmail = ""; // змінений Email
            int index = 0; // визначення чи був пройдений символ @

            for (int i = 0; i < Email.Length; i++)
                if (Email[i] != '@') TempEmail += (index == 0 ? '*' : Email[i]); // * або домен
                else { index++; TempEmail += Email[i]; } // @

            Text = Text.Replace(Email, TempEmail); // Email замінюється на TempEmail (змінений Email)
            Console.WriteLine("\n" + Text); // результат
        }


        Console.ReadKey();
    }
}