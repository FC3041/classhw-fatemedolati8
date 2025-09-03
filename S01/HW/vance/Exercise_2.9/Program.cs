using System;
class Program 
{
    static void Main(string[] args)
    {
        Factorial(-5);
        is_prime(-5);

    }
        static void Factorial(int n)
    {
        if(n<0)
        {
            Console.WriteLine("The input is incorrect");
            return;
        }
        long f=1;
        for(int i=1;i<n+1;i++)
        {
            f*=i;
        }  
        if(f<=0)
        {
            Console.WriteLine("The output is wrong");
            return;
        }
        if(f>=1)
        {
            Console.WriteLine(f);
        }          
        
    }
    static void is_prime(int n)
    {
        if(n<=0)
        {
            Console.WriteLine("The input is incorrect");
        }
        if(n==2)
        {
            Console.WriteLine("true");
        }
        if(n==1)
        {
            Console.WriteLine("false");
        }
        for(int i=2;i<n;i++)
        {
            if(n%i==0)
            {
                Console.WriteLine("false");
            }
        }
    }
}