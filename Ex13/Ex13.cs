using System;

class Ex13
{
    static void Main()
    {
        Dictionary<string, string> persons = new(); // словарь

        while (true)
        {
            string? command = Console.ReadLine(); // команда

            if (command?.ToLower() == "end") break; // завершення зчитування
            else if (command != null)
            {
                string[] info = command.Split(' '); // команда розбивається

                if (info[0].ToLower() == "a") // якщо А - додавання, зміна
                {
                    if (persons.ContainsKey(info[1])) persons[info[1]] = info[2]; // якщо є персона з таким ключом то змінюється значення
                    else persons.Add(info[1], info[2]); // якщо немає такої персони то створюється
                }
                else if (info[0].ToLower() == "s") // якщо S - виведення
                {
                    if (persons.ContainsKey(info[1])) Console.WriteLine(info[1] + " -> " + persons[info[1]]); // якщо є така персона то виводиться
                    else Console.WriteLine($"Contact {info[1]} does not exist."); // якщо немає персони то повідомлення про це
                }
                else if (info[0].ToLower() == "listall")
                {
                    // сортирування набору даних в LINQ через orderby
                    var temp = from p in persons
                               orderby p.Key
                               select p;

                    foreach (var p in temp)
                        Console.WriteLine(p.Key + " -> " + p.Value);
                }
            }
        }


        Console.ReadKey();
    }
}