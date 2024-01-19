int a = 1; 
int b = 20;

void Even(int a, int b)
{
    if (a % 2 == 0)
    {
        if (a > b) {return;}

        else
        {
            System.Console.Write(a + " ");
            Even(a + 2, b);
        }

    }
    else
    {
        if (a > b) {return;}

        else
        {
            Even(a + 1, b);
        }

    }

}



void Odd(int a, int b)
{
    if (a % 2 != 0)
    {
        if (a > b) {return;}

        else
        {
            System.Console.Write(a + " ");
            Odd(a + 2, b);
        }

    }
    else 
    {
        if (a > b) {return;}

        else
        {
            Odd(a + 1, b);
        }

    }
}

System.Console.WriteLine("Even numbers : ");
Even(a, b);
System.Console.WriteLine();
System.Console.WriteLine("Odd numbers : ");
Odd(a, b);