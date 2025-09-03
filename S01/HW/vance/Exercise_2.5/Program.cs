using System;
class Program
{
    static void Main(string[] args)
    {
        FToC();
        CToF();
        Factorial(5);
        Factorial_table(20);
        Console.WriteLine(power(2,3));
        quadradic(5,6,1);
        Console.WriteLine(average_of_squares(5));
        Console.WriteLine(average_of_squares1(4));
    }
    static void FToC()
    {
        Console.WriteLine("Enter the temperature in degrees Fahrenheit");
        var f=Console.ReadLine();
        double f2=Convert.ToDouble(f);
        string f3 = string.Format("{0:0.00}", f2); 
        Console.WriteLine("Fahrenheit:" +f3); 
        double C = (f2 - 32) * 1.8;
        string C2=string.Format("{0:0.00}",C); 
        Console.WriteLine("Celsius:" +C2);   
    }
    static void CToF()
    {
        Console.WriteLine("Enter the temperature in degrees Celsius");
        string C=Console.ReadLine();
        double C2=Convert.ToDouble(C);
        string C3=string.Format("{0:0.00}",C2);
        Console.WriteLine("Celsius:" +C3);   
        double f=(C2/1.8)+32;
        string f2=string.Format("{0:0.00}",f);
        Console.WriteLine("Fahrenheit:" +f2); 
    }
    static void Factorial(int n)
    {
        int f=1;
        for(int i=1;i<n+1;i++)
        {
            f*=i;
        }
        Console.WriteLine(f);
    }
    static void Factorial_table(int n)
    {
        long f=1;
        for(int i=1;i<n+1;i++)
        {
            f*=i;
            Console.WriteLine("factorial "+i+"="+f);
        }
    }
    static int power(int a,int b)
    {
        int p=1;
        if(b>=0)
        {for(int i=0;i<b;i++)
        {
            p*=a;
        } 
        }
        else
        {
           Console.WriteLine("Choose the right power");
        }
        return p;
    }
    static void quadradic(double a,double b,double c)
    {
        double delta=Math.Sqrt((b*b)-(4*a*c));
        double x1=(-b+delta)/(2*a);
        double x2=(-b-delta)/(2*a);    
        if(delta>0)
        {
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
        else if(delta==0)
        {
            Console.WriteLine(x1);
            
        }
        else
        {
            Console.WriteLine("there is no answer");
        }
    }
    static double average_of_squares(int n)
    {
        double avg=0;
        for(int i=0;i<n;i++)
        {
            avg+=(i*i);
        }
        avg/=n;
        return avg;

    }
    static double average_of_squares1(int n)
    {
        double avg=0;
        for(int i=1;i<n+1;i++)
        {
            avg+=(i*i);
        }
        avg/=n;
        return avg;
    }
}