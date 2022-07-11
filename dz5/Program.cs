//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int L = A;

for (int i = 0; i < B; i++)
{
    A = A * L;
}
Console.WriteLine("A^B = " + A);



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int A = Convert.ToInt32(Console.ReadLine());
int B = 0;
while (A > 0)
{
    B = B + A % 10;
    A = A / 10;
}
Console.WriteLine(B);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-999999, 999999);
}
Console.WriteLine($"[{String.Join(" ;", arr)}]");