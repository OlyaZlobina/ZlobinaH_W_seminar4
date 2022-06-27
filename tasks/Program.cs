// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void degreeOfNumber(int first, int second)
// {   
//     int result = 1;
//     for (int i = 0; i < second; i++)
//     {
//         result = result * first;
//     }
//     Console.Write(first + "," + second + "->" + " " + result + " ");
// }
// Console.WriteLine("Input number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// degreeOfNumber(A, B);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int summOfdigites(int number)
{
    int num1 = number / 1000 %10;
    int num2 = number / 100 %10;
    int num3 = number / 10 %10;
    int num4 = number %10;
    int summ = 0;
    if (number > 0)
    {
        summ = num4 + num3 + num2 + num1;
        Console.WriteLine(number + " -> " + summ + " ");
    }
    return summ;
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
summOfdigites(num);