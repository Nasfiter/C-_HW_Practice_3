// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
var num = Console.ReadLine();

void CheckingNumber(string num){
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"Число: {num} является палиндромом.");
  }
  else Console.WriteLine($"Ваше число: {num} - НЕ является палиндромом.");
}

if (num!.Length == 5){
  CheckingNumber(num);
}
else Console.WriteLine($"Введи правильное число");