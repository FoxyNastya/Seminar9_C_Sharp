/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

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

int SumMandN(int M, int N)
{
   if (M == N) return M;                
    else if (M < N) return N + SumMandN(M, N - 1);
    else return N + SumMandN(M, N + 1); 
}


Console.WriteLine();
int numberN = GetNaturalNumber("Введите натуральное число: ");
int numberM = GetNaturalNumber("Введите натуральное число: ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberN} до {numberM} = {SumMandN(numberN, numberM)}");
