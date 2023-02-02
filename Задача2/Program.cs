// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int num_A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num_B = int.Parse(Console.ReadLine()!);
if (num_A > num_B)
     {
         Console.WriteLine("Число " + num_A + " больше ");
     }
else
     {
         Console.WriteLine("Число " + num_B + " больше ");
     }