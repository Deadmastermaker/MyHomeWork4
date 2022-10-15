//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*double DigitStep (double num1, double num2)
{
    double digit = Math.Pow(num1,num2);
    return digit;
}


Console.Write("Input number A: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number B: ");
double numB = Convert.ToDouble(Console.ReadLine());
double answear = DigitStep(numA,numB);
Console.WriteLine($"Answear = {answear}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int NumberSum (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int Summa = NumberSum(num);
Console.WriteLine($"Summa {num} it is {Summa}");
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*int[] RandomArray(int size)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    newArray[i] = new Random().Next();

    return newArray;
}




void RanArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] +" ");
Console.WriteLine();

}

Console.Write("Input array: ");
int arr = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(arr);
RanArray(myArray);

*/