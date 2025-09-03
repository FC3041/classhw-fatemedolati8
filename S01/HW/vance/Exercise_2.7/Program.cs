using System;
class Program
{
    static void Main(string[] args)
    {
        print_absolute_values();
        Factorial_table(20);
        Console.WriteLine(is_divisible(20,3));
        Console.WriteLine(is_prime(4));
        prime_list();
        Console.WriteLine(fibonacci(5));
        fibonacci_list();
        Console.WriteLine(days_in_month(2,2024));
        Console.WriteLine(days_before_date(2014, 1,1));
        Console.WriteLine(days_before_date(2014, 12, 31));
        Console.WriteLine(day_of_the_week(2014,7,22));

    }
    static int absolute(int value)
    {
        if(value<0)
        {
            value=-value;
        }
        return value;
    }
    static void print_absolute_values()
    {
        int[] list={-100, -1, 0, 1 , 1000};
        for(int i=0;i<list.Length;i++)
        {
            Console.WriteLine(absolute(list[i]));
        }
    }
    static long Factorial(int n)
    {
        long f=1;
        for(int i=1;i<n+1;i++)
        {
            f*=i;
        }
        return f;
    }
    static void Factorial_table(int n)
    {
        for(int i=1;i<n+1;i++)
        {
            Console.WriteLine("factorial "+i+"="+Factorial(i));
        }
    }
    static bool is_divisible(int a,int b)
    {
        if(a%b==0)
        {
            return true;
        }
        return false;
    } 
    static bool is_prime(int n)
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
        return true;
    }
    static void prime_list()
    {
        for(int i=1;i<100;i++)
        {
            if(is_prime(i)==true)
            {
                Console.WriteLine(i);
            }
        }
    }
    static int fibonacci(int n)
    {
        int a=1;
        int b=1;
        if(n==1 || n==2)
        {
            return 1;
        }
        for(int i=0;i<n-2;i++)
        {
            int c=b;
            b=a+b;
            a=c;
        }
        return b;
    }
    static void fibonacci_list()
    {
        for(int i=1;i<21;i++)
        {
            Console.WriteLine(i+" --> "+fibonacci(i));
        }
    }

    static bool is_leap_year(int year)
    {
        if(year%4==0 && year%100!=0)
        {
            return true;
        }
        return false;
    }    
    static int days_in_month(int n,int year)
    {   
        if(is_leap_year(year)==true && n==2)
        {
            return 29;
        }
        int[] days={31,28,31,30,31,30,31,31,30,31,30,31};
        return days[n-1];
    }
    static int days_before_date(int year,int month,int day)
    {
        int days=0;
        for(int i=1;i<month;i++)
        {
            days+=days_in_month(i,year);
        }
        days+=day-1;
        return days;
    }
    static string day_of_the_week(int year,int month,int day)
    {
        string[] days={"Wednesday","Thursday","Friday","Saturday","Sunday","Monday","Tuesday"};
        int d=days_before_date(year,month,day);
        return days[d%7];

    }

}
