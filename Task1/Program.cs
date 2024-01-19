void Recursia(int a)
{
    if (a == 0)
    {
        return;
    }
    else
    {
        Recursia(a - 1);
        System.Console.Write(a + " ");
    }

}
int x = Convert.ToInt32(Console.ReadLine());
Recursia(x);