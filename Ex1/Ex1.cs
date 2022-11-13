using System;

class Ex1
{
    static void Main()
    {
        string? str = Console.ReadLine();

        if (str != null)
        {
            string temp = "";

            for (int i = str.Length - 1; i >= str.Length / 2; i--)
                temp += str[i];
            for (int i = str.Length / 2 - 1; i >= 0; i--)
                temp += str[i];

            str = temp;
            Console.WriteLine(str);
        }


        Console.ReadKey();
    }
}