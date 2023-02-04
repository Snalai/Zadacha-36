// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void fun(int b)
{
    int[] mas = new int[b];
    int a = 0;
    int s = 0;
    while (a < mas.Length)
    {
        int r = new Random().Next(0, 100);
        mas[a] = r;
        if (mas[a] % 2 == 1)
        {
            s = s + mas[a];
        }
        a++;
    }
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна: {s}");
}
Console.Write("Выберите ширину массива: ");
int w = Convert.ToInt32(Console.ReadLine());
fun(w);


