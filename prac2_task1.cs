Console.Write("введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("элемент " + (i + 1) + ": ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
for (int i = 0; i < n; i++)
    sum += a[i];

double sr = (double)sum / n;

Console.Write("обратный порядок: ");
for (int i = n - 1; i >= 0; i--)
    Console.Write(a[i] + " ");
Console.WriteLine();

int blizko = a[0];
double min = Math.Abs(a[0] - sr);

for (int i = 1; i < n; i++)
{
    double raz = Math.Abs(a[i] - sr);
    if (raz < min)
    {
        min = raz;
        blizko = a[i];
    }
}

Console.WriteLine("среднее: " + sr);
Console.WriteLine("ближайшее число: " + blizko);