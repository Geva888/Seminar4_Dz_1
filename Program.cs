//  Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int number(int numA, int numB)
{
    int result = 1;
    for(int i = 1; i <= numB; i++)
    {
        result *= numA;
    }
    return result;
}

System.Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int userNumber = number(numA , numB);
System.Console.WriteLine($"{userNumber}");