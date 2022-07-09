Console.Clear();
Console.WriteLine("введите через enter два целых числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 == num2*num2)
Console.WriteLine($"{num1} является квадратом {num2}");
else Console.WriteLine($"{num1} не является квадратом {num2}");   
