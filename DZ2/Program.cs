Console.Clear();
Console.WriteLine("введите через enter два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    Console.WriteLine($"число {num1} больше числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"число {num1} меньше числа {num2}");
}
else
{
    Console.WriteLine($"число {num1} равно числу {num2}");
}
