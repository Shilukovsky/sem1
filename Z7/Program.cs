Console.Clear();
Console.WriteLine("введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int last = num % 10;
Console.WriteLine($"последнее число {last}");
