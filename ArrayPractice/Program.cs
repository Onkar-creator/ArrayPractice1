//See https://aka.ms/new-console-template for more information
using System.Runtime;

Console.WriteLine("Hello, World!");

//To find Maximum number
Console.WriteLine("1) To find maximum number");
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
Console.WriteLine("-----------------------------------------------------------");



//To find Minimum Number
Console.WriteLine("2) To find minimum number");

int[] Min = new int[10];
int MinNum;
Console.WriteLine("Please enter 10 numbers");
for (int i = 0; i < 10; i++)
    Min[i] = Convert.ToInt32(Console.ReadLine());
MinNum = Min[0];
for (int i = 1; i < 10; i++)
{
    if (Min[i] < MinNum)
    {
        MinNum = Min[i];
    }
}
Console.WriteLine("Minimum value of number is:" + MinNum);
Console.ReadLine();
Console.WriteLine("-----------------------------------------------------------");



//To find number of FistClass students
Console.WriteLine("3) To find number of first class students");
int[] marks = new int[10];
int FirstClass=0;
Console.WriteLine("Please enter marks of 10 students");

for (int i = 0; i < 10; i++)
    marks[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    if (marks[i] >= 60)
    {
        FirstClass++;
    }
}
Console.WriteLine("Number of students passed with first class are:" + FirstClass);
Console.WriteLine("-----------------------------------------------------------");


//To find number of students in Distinction, first class, passed and failed
Console.WriteLine("4) To find number of students in distinction, first class, passed and failed");
int[] StudentMarks = new int[12];
int distinction = 0;
int firstclass = 0;
int passed = 0;
int failed = 0;

Console.WriteLine("Please enter marks of 12 students");
for (int i = 1; i < 12; i++)
    StudentMarks[i] = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < 12; i++)
{
    if (StudentMarks[i] >= 75)
    {
        distinction++;
    }

    if (StudentMarks[i] < 75 && StudentMarks[i] >= 60)
    {
        firstclass++;
    }

    if (StudentMarks[i] < 60 && StudentMarks[i] >= 35)
    {
        passed++;
    }

    if (StudentMarks[i] < 35)
    {
        failed++;
    }

}
Console.WriteLine("Number of students passed with distinction class are:" + distinction);
Console.WriteLine("Number of students passed with first class are:" + firstclass);
Console.WriteLine("Number of students passed are:" + passed);
Console.WriteLine("Number of students failed are:" + failed);
Console.ReadLine();
Console.WriteLine("-----------------------------------------------------------");



//To find number of prime values
Console.WriteLine("5) To find number of prime values");
int[] Numbers = new int[20];
int PrimeNum=0;

Console.WriteLine("Please enter 20 numbers");
for (int i = 1; i < 20; i++)
    Numbers[i] = Convert.ToInt32(Console.ReadLine());

for (int i=2; i<20; i++)
{
    //bool result = isPrime(StudentMarks[i]);
    //isPrime = Convert.ToBoolean(Console.ReadLine());

    if (Numbers[i]%2!=0)
    {
        PrimeNum++;
    }
}
Console.WriteLine("Number of prime values are:"+PrimeNum);
