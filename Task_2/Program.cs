//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Сбор данных из консоли пользователя
Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine());
// Поиск максимального числа
int max = Math.Max(number_3, Math.Max(number_1, number_2));
// Вывод в консоли максимального числа
Console.WriteLine($"Большее число : {max}");
