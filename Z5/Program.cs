Console.Clear();
Console.WriteLine("введите натуральное число");
int n = int.Parse(Console.ReadLine());
int i = 0;
if (n<0)
{
     i = n;
     n = n * -1;
}
else
{
     i = -n;
}          
while (i <= n)
{     
     Console.Write($"{i}");
     i++;
}