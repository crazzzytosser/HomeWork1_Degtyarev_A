/*

 //Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2)
{
    Console.Write($"{n1} = {n2}");
}
else
{
         if (n1 > n2)
        {  
             Console.WriteLine($"{n1} > {n2}");
        }
         else
        {
              Console.Write($"{n1} < {n2}");
        }
}

*/

/*

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите число 1: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
    int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    if (n1 > n3)
    {
        Console.Write($"{n1}");
    }
    else
    {
        Console.Write($"{n3}");
    }
}
else
{
    if (n2 > n3)
    {
        Console.Write($"{n2}");
    
    }
    else
    {
        Console.Write($"{n3}");
    }

}

*/

/*

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.Write($"Число {n} является четным");
}
else
{
    Console.Write($"Число {n} является нечетным!");
}

*/

/*

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 1)
{
    int current = 2;
    
    while (n >= current)
    {
        Console.Write(current + " ");
        current += 2;
    }
}
else
{
    Console.Write("Ошибка ввода, попробуйте еще раз)");
}

*/
