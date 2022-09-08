// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(-20, 50);
        Console.Write($"{num[i]}, ");
    }
}

int SummElements(int[] numbers)
{
    int sum = 0;
    for (int j = 1; j < numbers.Length; j = j + 2 )
        sum = sum + numbers[j];

    return sum;
}

int[] array = new int[10];
FillArray(array);
Console.WriteLine();
Console.Write("Сумма элементов на нечетных позициях = ");
Console.WriteLine(SummElements(array));
