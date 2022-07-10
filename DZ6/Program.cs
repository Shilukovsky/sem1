Console.Clear();
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"число {num} четное ");
}
else
{
    Console.WriteLine($"число {num} нечетное ");
}