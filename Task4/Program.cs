void Digit(int a)
{
    if(a == 0)
    {
        return ;
    }
    else
    {
        Digit(a /10);
        System.Console.Write(a % 10 + " " );
    }
}
int x = Convert.ToInt32(Console.ReadLine());
Digit(x);