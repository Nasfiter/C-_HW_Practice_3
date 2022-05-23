// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Ввседите целое число: ");
int N = Convert.ToInt16(Console.ReadLine());

int index = 1;
//int number = index; 

while (index < (N + 1))
{
    int number = index;
    int result = number * number * number; 
    Console.WriteLine($"Результат= {result}");
    index++;
}