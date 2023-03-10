/* Задача 63: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"


int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
    }
  }

  return result;
}

void PrintNumber(int N, int i)
{
  if (i <= N)
  {
    Console.Write($"{i} ");
    i++;
    PrintNumber(N, i);
  }
}

Console.WriteLine();
int i = 1;
int numbers = GetNaturalNumber("Введите натуральное число: ");
PrintNumber(numbers, i);
*/


/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"

string NumberRec (int m, int n)
{
    if (m < n) return $"{m}, " + NumberRec (m+1, n);
    else return String.Empty;
}
Console.WriteLine (NumberRec(4,8) +"8");

Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int SumOfNumbers (int number)
{
    if(number == 0 )
        return number;
    else 
        return number % 10 + SumOfNumbers(number / 10);
    
}

int sum = SumOfNumbers(453);
Console.WriteLine(sum);

/*Задача 69: Напишите программу, которая на вход 
принимает два числа A и B, и возводит число А в целую 
степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

int Power (int a, int b)
{
    if(b == 0)
        return 1;
    else
        return a * Power(a, b-1);
}

int result = Power(5, 3);
Console.WriteLine(result);

*/

