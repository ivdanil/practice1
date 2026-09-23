Console.Write("введите n студентов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("введите m предметов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] ocenki = new int[n, m];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("студент " + (i + 1) + ":");
    for (int j = 0; j < m; j++)
    {
        Console.Write("предмет " + (j + 1) + ": ");
        ocenki[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < m; j++)
        sum += ocenki[i, j];

    double sr = (double)sum / m;
    Console.WriteLine("студент " + (i + 1) + " средний балл: " + sr);
}