//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}