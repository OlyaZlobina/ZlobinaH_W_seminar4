// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void degreeOfNumber(int first, int second)
{   
    int result = 1;
    for (int i = 0; i < second; i++)
    {
        result = result * first;
    }
    Console.Write(first + "," + second + "->" + " " + result + " ");
}
Console.WriteLine("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());
degreeOfNumber(A, B);
