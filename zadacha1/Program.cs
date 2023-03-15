//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetSizeFromUser(string text)//Запрос значения N(size).
{
    bool flag = false;
    int value = 0;
    while (!flag)
    {
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(), out value);
        if (value <= 0)
        {
            Console.WriteLine("Введите натуральное число больше 0.");
            flag = false;
        }
    }
    return value;
}

void GetResultFromSizeToOne(int size)//Вывод результата от N(size) до 1.
{
    Console.Write($"{size} ");
    if (size == 1) return;
    else GetResultFromSizeToOne(size - 1);
}

int size = GetSizeFromUser("Введите натуральное число: ");
GetResultFromSizeToOne(size);