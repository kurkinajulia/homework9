//*Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int GetValueFromUser(string text)//Запрос значений m и n.
{
    bool flag = false;
    int value = 0;
    while (!flag)
    {
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(), out value);
        if (value < 0)
        {
            Console.WriteLine("Необходимо ввести неотрицательное число");
            flag = false;
        }
    }
    return value;
}

int CountAkkerman(int m, int n) //Вычисление функции Аккермана.
{
    if (m == 0) ////Если m = 0, то n + 1.
        return n + 1;
    else
    if ((m > 0) && (n == 0)) 
        return CountAkkerman(m - 1, 1); //Если m > 0, n = 0, то A(m - 1, 1).
    else
        return CountAkkerman(m - 1, CountAkkerman(m, n - 1)); 
        //Если m > 0, n > 0, то A(m - 1, A(m, n - 1)).
}

int m = GetValueFromUser("Введите первое число M: ");
int n = GetValueFromUser("Введите второе число N: ");
Console.WriteLine($"Результат вычисления функции Аккермана: {CountAkkerman(m, n)}");
