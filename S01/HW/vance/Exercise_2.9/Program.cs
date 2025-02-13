using System;
class Program 
{
    static void Main(string[] args)
    {
        Factorial(5);
        is_prime(5);

    }
        static void Factorial(int n)
    {
        int shart=5;
        if(shart==5)
        {
        int f=1;
        for(int i=1;i<n+1;i++)
        {
            f*=i;
        }            
        }
        Console.WriteLine(f);
    }
        static bool is_prime(int n)
    {
        bool flag=true;
        if(flag==true)
        {
        if(n==2)
        {
            return true;
        }
        if(n<2)
        {
            return false;
        }
        for(int i=2;i<n;i++)
        {
            if(is_divisible(n,i)==true)
            {
                return false;
            }
        }            
        }

        return true;
    }
}