int cnt = 0;
int a = Convert.ToInt32(Console.ReadLine());
int Digit(int a)
{
    
    if(a == 0)
    {
        return cnt ;
    }
    else
    {
        cnt ++;
        Digit(a /10);
    }
    return(cnt);
}

System.Console.WriteLine(Digit(a));