void Recursia(int a)
{
    if (a == 0)
    {
        return;
    }
    else
    {
        System.Console.Write(a + " ");
        Recursia(a - 1);
        
    }

}
int x = Convert.ToInt32(Console.ReadLine());
Recursia(x);