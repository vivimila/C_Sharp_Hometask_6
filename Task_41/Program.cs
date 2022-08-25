// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number == 0)

{
    Console.Write("Вы ввели недопустимое значение");
    return;
}

int[] GetArray(int size)

{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-20, 30);
    }
    return array;
}
int[] result = GetArray(number);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > 0)
            count++;

        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

PrintArray(result);
Console.Write($"Количество положительных чисел в массиве: {count}");