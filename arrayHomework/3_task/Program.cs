//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
int[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };

int min = 0;
int max = 0;
int summ = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
summ = min + max;
System.Console.Write("сумма минимального и максимального элементов равна ");
System.Console.Write(summ);