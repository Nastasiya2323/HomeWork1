//            1   вход - два числа, выход - какое число больше, а какое меньше

// Console.WriteLine("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// if (numA > numB)
// {
//     Console.WriteLine($"Число {numA} большеe, а число {numA} - меньшее");
// }
// else 
// {
//     Console.WriteLine($"Число {numB} большеe, а число {numA} - меньшее");
// }

//            2   вход - три числа, выход - максимальное

// Console.WriteLine("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int numD = Convert.ToInt32(Console.ReadLine());

// int max = numA;

// if (numB > max) 
// {
//         Console.WriteLine($"Число {numB} является максимальным");  
// }
// else if (numD > max) 
// {
//        Console.WriteLine($"Число {numD} является максимальным");
// }
// else
// {
//     Console.WriteLine($"Число {numA} является максимальным");
// }

//           3   вход - одно число, выход - четное ли число или нет

// Console.WriteLine("Введите число: ");
// int numA = Convert.ToInt32(Console.ReadLine());

// if (numA%2 == 0)
// {
//     Console.WriteLine ($"Число {numA} четное");
// }
// else 
// {
//     Console.WriteLine ($"Число {numA} нечетное");
// }

//           4   вход - одно число N, выход - все четные число от 1 до N

Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine());

for (int a = 2; a <= n; a = a + 2)
{
      Console.WriteLine (a);
}
