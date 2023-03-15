//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120

// M = 4; N = 8. -> 30

//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int GetDataFromUser(string text)//Запрос значений M и N.
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

int GetSumValues(int valueFirst, int valueLast)//Вывод суммы натуральных элементов в промежутке от M до N.
{
    {
        if (valueFirst == valueLast) return valueLast;// Или 0? или нужно вывести сообщение, что M должно быть > N? 
        //В зависимости от уточнённых условий, от того, что считаем суммой натуральных элементов в случае, когда M = N.
        else return valueLast + GetSumValues(valueFirst, valueLast - 1);
    }
}

int CheckValues(int valueFirst, int valueLast)//Проверяем, что число M > N. Меняем значения, если наоборот.
{
    if (valueFirst <= valueLast) return GetSumValues(valueFirst, valueLast);
    else return GetSumValues(valueLast, valueFirst);
}

int valueFirst = GetDataFromUser("Введите число M: ");
int valueLast = GetDataFromUser("Введите число N: ");
Console.WriteLine($"Сумма элементов от {valueFirst} до {valueLast} = {CheckValues(valueFirst, valueLast)}");