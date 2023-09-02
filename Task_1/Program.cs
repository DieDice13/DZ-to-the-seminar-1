Console.Write("Enter first number : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number : ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (max > num2)
{
    Console.WriteLine("Max : " + max);
    Console.Write("Min : " + num2);
}
else
{
    Console.WriteLine("Max : " + num2);
    Console.Write("Min : " + max);
}