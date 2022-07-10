Console.Clear();
Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= n)
     if(i % 2 == 0)
{     
       Console.Write ($"{i} ");
  i++;
}
    else
    {
     i++;
    } 