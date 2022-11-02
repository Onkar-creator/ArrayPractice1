// See https://aka.ms/new-console-template for more information
using System.Runtime;

Console.WriteLine("Hello, World!");

int[] num = new int[10];
int MaxNum;
Console.WriteLine("Please enter 10 numbers");

for (int i = 0; i < 10; i++)
    num[i] = Convert.ToInt32(Console.ReadLine());
MaxNum = num[0];

for (int i = 1; i < 10; i++)
{
    if (num[i] > MaxNum)
    {
        MaxNum = num[i];
    }
}
Console.WriteLine("Maximum value of number is:" + MaxNum);

Console.ReadLine();


int[] Min = new int[10];
int MinNum;
Console.WriteLine("Please enter 10 numbers");
for (int i=0; i < 10; i++)
Min[i]= Convert.ToInt32(Console.ReadLine());
MinNum = Min[0];
for (int i=1; i<10; i++)
{
    if (Min[i] < MinNum )
    {
        MinNum = Min[i];
    }
}
Console.WriteLine("Minimum value of number is:" + MinNum);
Console.ReadLine();



