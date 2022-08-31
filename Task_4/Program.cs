//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Сбор данных из консоли пользователя
Console.Write("Введите число: ");
int number_1 = int.Parse(Console.ReadLine());
//Вторая переменная дана по условию
int number_2 = 1;
// будем записывать в данную переменную результат
string Result = "";

//проверка на 0 и на 1 
if(number_1 ==0 || number_1 == 1)
 {
    Result ="  нет четных чисел в промежутке";
 }
else
{
// проверка на отрицательные числа    
 if(number_1<0)
 {
  while(number_2 >= number_1)
  {
    if (number_1 % 2 ==0)
    {
        Result = Result +", " + number_1; number_1++;
        }
    else{
        number_1++;
        }
  }
 }
 else
 {
// если дошли у нас положительные числа
 while (number_2 <= number_1)
 {
  if (number_2 % 2 ==0)
  {
Result = Result +", " + number_2;               
number_2++;
  }
else 
{
number_2++;
}
}
}
}
// удаляем первые символы, и выводим результат
Console.WriteLine(Result.Remove(0,2));