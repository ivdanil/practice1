List<int> chisla = new List<int>();

while (true)
{
    Console.Write("введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());

    if (chisla.Contains(x))
    {
        Console.WriteLine("повторение");
        break;
    }

    chisla.Add(x);
}

Console.Write("массив: ");
for (int i = 0; i < chisla.Count; i++)
    Console.Write(chisla[i] + " ");
Console.WriteLine();