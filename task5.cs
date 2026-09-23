// int[,] a = new int[3, 3];
// int[,] b = new int[3, 3];

// Console.WriteLine("введите матрицу: 3 строки по 3 числа через пробел");
// for (int i = 0; i < 3; i++)
// {
//     string line = Console.ReadLine() ?? "";
//     string[] parts = line.Split(' ');
//     for (int j = 0; j < 3; j++)
//     {
//         a[i, j] = Convert.ToInt32(parts[j]);
//     }
// }

// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         b[j, i] = a[i, j];
//     }
// }

// Console.WriteLine("результат:");
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         Console.Write(b[i, j] + " ");
//     }
//     Console.WriteLine();
// }