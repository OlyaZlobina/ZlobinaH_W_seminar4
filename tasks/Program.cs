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


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] eightElementsArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10); 
    }
    return array;
}

void ShowEightElementsArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] myarray = eightElementsArray(8);
ShowEightElementsArray(myarray);
Console.Write(" ->  [");
ShowEightElementsArray(myarray);
Console.WriteLine("] ");