using System;

class Ex11
{
    static void Main()
    {
        string? A = Console.ReadLine();
        string? B = Console.ReadLine();

        if (A != null && B != null)
            for (int i = 0; i < A.Length; i++)
                if (B.Contains(A[i])) // якщо в В є A[i] то припиняється перевірка і виводиться yes
                {
                    Console.WriteLine("yes");
                    break;
                }
                else if (i + 1 >= A.Length) // якщо в В немає жодного A[i] то виводиться no
                    Console.WriteLine("no");


        Console.ReadKey();
    }
}