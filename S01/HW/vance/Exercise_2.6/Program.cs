using System;
class Program
{
    static void Main(string[] args)
    {
        is_leap_year_table();
        MoreAsciiiArt(4);
        print_cone(7);
        print_cone_fard();
        Console.WriteLine(print_month(5));
        print_month_table();
        ComputeChange(8);
        Pythagorean();

    }
    static string is_leap_year(int year)
    {
        if(year%4==0 && year%100!=0)
        {
            return "True";
        }
        return "False";
    }
    static void is_leap_year_table()
    {
        int[] list={1792,1796,1800,1804,1900,1904,2000,2004};
        for(int i=0;i<list.Length;i++)
        {
            Console.WriteLine(list[i]+" --> "+is_leap_year(list[i]));
        }
    }
    static void MoreAsciiiArt(int n)
    {
        for(int i=1;i<n+1;i++)
        {
        if(i%2==1)
        {
            for(int j=0;j<i;j++)
            {
                Console.Write("%");
            }
        }
        else
        {
            for(int j=0;j<i;j++)
            {
                Console.Write("*");
            }            
        }
        Console.Write("\n");
    }
}
    static void print_cone(int size)
    {
        for(int i=-1;i<size/2;i++)
        {
            Console.Write(" ");
        }
        Console.Write("^");
        for(int i=0;i<size/2;i++)
        {
            Console.Write("\n");
            for(int k=size/2-i;k>0;k--)
            {
                Console.Write(" ");
            }
            for(int j=-1;j<i;j++)
            {
                Console.Write("/");
            }
            Console.Write("|");
            for(int p=-1;p<i;p++)
            {
                Console.Write("\\");
            }
        }  
        Console.Write("\n");      
    }
    static void print_cone_fard()
    {
        for(int i=1;i<10;i++)
        {
            if(i%2==1)
            {
                print_cone(i);
            }
        }
    }
    static string print_month(int number)
    {
        string[] list={"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
        return (list[number-1]);
    }
    static void print_month_table()
    {
       for(int i=1;i<13;i++)
        {
            Console.WriteLine(i+" --> "+print_month(i));
        }        
    }    
    static void ComputeChange(int cent)
    {
        int n2=100-cent;
        int quarter=(int)(n2/25);
        if(quarter>0)
        {
            Console.WriteLine(quarter);
        }
        n2-=quarter*25;
        int dime=(int)(n2/10);
        if(dime>0)
        {
            Console.WriteLine(dime);
        }
        n2-=dime*10;
        int nickel=(int)(n2/5);
        if(nickel>0)
        {
            Console.WriteLine(nickel);
        }
        int penny=n2-(nickel*5);
        if(penny>0)
        {
            Console.WriteLine(penny);
        }
    }
    static void Pythagorean()
    {
        for(int a=1;a<100;a++)
        {
            for(int b=1;b<100;b++)
            {
                for(int c=1;c<100;c++)
                {
                    if ((c*c==b*b+a*a) &&(a<b))
                    {
                        Console.WriteLine("a= "+ a +" b= "+b+" c= "+c);
                    }
                }
            }
        }
    }
} 

