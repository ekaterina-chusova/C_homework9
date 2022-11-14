// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Summa(int number1, int number2)
{
    if (number1 < number2)
    {
        if (number1 == number2) return number2;
        return number1 + Summa(number1 + 1, number2);
    }
    else
    {
        if (number1 == number2) return number2;
        return number1 + Summa(number1 - 1, number2);
    }

}

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {Summa(m, n)}");