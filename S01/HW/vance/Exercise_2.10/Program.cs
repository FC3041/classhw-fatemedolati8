using System;
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine(eulers_constant(0.001));
        Console.WriteLine(exp(1, 0.000001));
        Console.WriteLine(exp(2, 0.000001));
        Console.WriteLine(exp2(1, 0.000001));
        Console.WriteLine(exp2(2, 0.000001));
        Console.WriteLine(near(2,3));
        Console.WriteLine(near(exp2(1, 0.000001),exp(1, 0.000001)));
        Console.WriteLine(sin(45));
        Console.WriteLine(sin(90));
        Console.WriteLine(sin(0));
        Console.WriteLine(square_root(2, 0.000001));
        Console.WriteLine(root(2,3, 0.000001));
        Console.WriteLine(ln(2,0.00001));
        stats();
    }
    static double Factorial(double n)
    {
        double f=1;
        for(int i=1;i<n+1;i++)
        {
            f*=i;
        }
        return f;
    }
    static double eulers_constant(double precision)
    {
        double e=0;
        double n=0;
        while((1/Factorial(n))>precision)
        {
            e+=1/Factorial(n);
            n++;
        }
        return e;
    }
    static double power(double a,double b)
    {
        double p=1;
        for(int i=0;i<b;i++)
        {
            p*=a;
        } 
        return p;
    }
    static double exp(double x,double precision)
    {
        double e=0;
        double n=0;
        while((power(x,n)/Factorial(n))>precision)
        {
            e+=power(x,n)/Factorial(n);
            n++;
        }
        return e;
    }
    static double exp2(double x,double precision)
    {
        double e=0;
        double n=1;
        double f=1;
        double x2=1;
        while((x2/f)>precision)
        {
            e+=x2/f;
            x2=x2*x;
            f=f*n;
            n++;
        }
        return e;
    }
    static double abs(double x)
    {
        if(x<0)
        {
            x=-x;
        }
        return x;
    }
    static bool near(double x,double y,double closeness=0.001)
    {
        if(abs(x-y)<closeness)
        {
            return true;
        }
        return false;
    }
    static double sin(double x)
    {
        double rad=(x*3.14) /180;
        double e=0;
        double n=0;
        double precision=0.000001;
        double alamat=1;
        while((power(rad,n)/Factorial(n))>precision)
        {
            if(n%2==1)
            {
                e+=(power(rad,n)/Factorial(n))*alamat;
                alamat*=-1;
            }
            n++;
        }
        return e;
    }
    static double square_root(double x,double precision)
    {
        double lower=0;
        double upper=x;
        while(abs(upper-lower)>precision)
        {
            double min=(lower+upper)/2;
            if(min*min<x)
            {
                lower=min;
            }
            if(min*min>x)
            {
                upper=min;
            }
        }
        return (lower+upper)/2;
    }
    static double root(double x,double n,double precision)
    {
        double lower=0;
        double upper=x;
        while(abs(upper-lower)>precision)
        {
            double min=(lower+upper)/2;
            if(power(min,n)<x)
            {
                lower=min;
            }
            if(power(min,n)>x)
            {
                upper=min;
            }
        }
        return (lower+upper)/2;        
    }
    static double ln(double x,double precision)
    {
        double lower=-100;
        double upper=100;
        double min;
        while(abs(lower-upper)>precision)
        {
            min=(lower+upper)/2;
            if(exp(min,precision)<x)
            {
                lower=min;
            }
            if(exp(min,precision)>x)
            {
                upper=min;
            }
        }
        return (lower+upper)/2;
    }
    static double max(List<double> list)
    {
        double m=0;
        for(int i=0;i<list.Count;i++)
        {
            if(list[i]>m)
            {
                m=list[i];
            }
        }
        return m;
    }
    static double min(List<double> list)
    {
        double m=max(list);
        for(int i=0;i<list.Count;i++)
        {
            if(list[i]<m)
            {
                m=list[i];
            }
        }    
        return m;    
    }
    static void stats()
    {
        List<double> list2=new List<double>();
        int n=0;
        double x=0;
        while(x!=-1)
        {
            x=Convert.ToDouble(Console.ReadLine());
            list2.Add(x);
            n++;
        }
        list2.Remove(-1);
        Console.WriteLine("The number of entries:"+ ((list2.Count)));
        double sum=0;
        for(int i=0;i<list2.Count;i++)
        {
            sum+=list2[i];
        }
        double avg=sum/(list2.Count);
        Console.WriteLine("The average:"+ (avg));
        Console.WriteLine("The minimum:"+ (min(list2)));
        Console.WriteLine("The maximum:"+ (max(list2)));
        
    }
}
