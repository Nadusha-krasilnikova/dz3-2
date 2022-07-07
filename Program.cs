// найти скмму чисел от 1 до а
Console.WriteLine("введите число ");
int a = int.Parse(Console.ReadLine());
int p=0;
for (int i=1; i<=a; i++)
{
    p=p+i;
}
    Console.WriteLine($"сумма чисел равна {p}");

