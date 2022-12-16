// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void CountPositive(int[] array, out int count)
{
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = EnterNumber($"Введите {i + 1} число");
        if (array[i] > 0)
        {
            count++;
        }
    }
}

// пользователь вводит M чисел
int size = EnterNumber("Введите M чисел ");
int[] array = new int[size];
// посчитать сколько чисел больше 0
CountPositive(array, out int count);
Console.WriteLine("Чисел больше нуля: " + count);
