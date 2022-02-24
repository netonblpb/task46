// Написать программу масштабирования фигуры

Console.Clear();

Console.Write("Введите количество вершин: ");
int dots = int.Parse(Console.ReadLine());
int kms = 1;
int[] xs = new int[dots];
int[] ys = new int[dots];

for (int i = 0; i < dots; i++)
{
    Console.Clear();
    Console.WriteLine($"Точка {i + 1 }");
    Console.Write("Введите X: ");
    xs[i] = int.Parse(Console.ReadLine());    
    Console.Write("Введите Y: ");
    ys[i] = int.Parse(Console.ReadLine());
}

void Print(int[] x, int[] y , int k)
{
    for (int i = 0; i < dots; i++)
    {
        Console.Write($"({xs[i] * k};{ys[i] * k}) ");        
    }
}

Console.Clear();
Console.Write("Начальная фигура: ");
Print(xs, ys, kms);
Console.WriteLine();
Console.Write("Введите коэффициент масштабирования: ");
kms = int.Parse(Console.ReadLine());
Console.Write($"Фигура с коэффициентом {kms}: ");
Print(xs, ys, kms);