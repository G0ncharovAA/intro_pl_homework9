/*
* Урок 9. Как не нужно писать код. Часть 3
*
* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
* натуральные числа в промежутке от M до N.
*
* M = 1; N = 5. -> ""1, 2, 3, 4, 5""
* M = 4; N = 8. -> ""4, 6, 7, 8""
*
* Решение:
*/

string writeNumbers(int start, int end)
{
    if (start >= end) return start.ToString();
    return (start + ", " + writeNumbers(start + 1, end));
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
if (m > n)
{
    Console.WriteLine("Пустое множество.");
}
else
{
    Console.WriteLine(writeNumbers(m, n));
}

/*
* Задача 66: Задайте значения M и N. Напишите программу, которая
* найдёт сумму натуральных элементов в промежутке от M до N.
*
* M = 1; N = 15 -> 120
* M = 4; N = 8. -> 30
*
* Решение:
*/

int summNumbers(int start, int end)
{
    if (start >= end) return start;
    return start + summNumbers(start + 1, end);
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
if (m > n)
{
    Console.WriteLine("Сумма элементов пустого множества равна нолю.");
}
else
{
    Console.WriteLine(summNumbers(m, n));
}

/*
* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
* Даны два неотрицательных числа m и n.
*
* m = 2, n = 3 -> A(m,n) = 29
*
* Решение:
*/

/*
* В примере неточность: A(2,3) = 9 
* А вот A(3,2) действительно равен 29
*
* https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
*/

int akkerman(int m, int n) {
        if (m == 0) {
            return n + 1;
        }
        else if (n == 0 && m > 0) {
            return akkerman(m - 1, 1);
        }
        else {
            return akkerman(m - 1, akkerman(m, n - 1));
        }
    }

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана от {m}, {n} равна {akkerman(m,n)}");