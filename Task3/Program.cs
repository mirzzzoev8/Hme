int Sum(int a)
{
    if(a == 0)
    {
        return 0;
    }
    else
    {
        return a + Sum(a - 1);
    }
}
int x  = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(x));