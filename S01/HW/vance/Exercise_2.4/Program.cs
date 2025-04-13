using System;
class Program
{
    static void Main(string[] args)
    {
        print_left_triangle(4);
        print_left_triangle_char(4,'%');
        print_right_triangle(4);
    }
    static void print_left_triangle(int n1)
    {
        for(int i=1;i<1+n1;i++)
        {
            for(int j=0;j<i;j++)
            {
               Console.Write("*"); 
            } 
            Console.Write("\n");
        }
    }
    static void print_left_triangle_char(int n1,char s)
    {
        for(int i=1;i<1+n1;i++)
        {
            for(int j=0;j<i;j++)
            {
               Console.Write(s); 
            } 
            Console.Write("\n");
        }
    }
    static void print_right_triangle(int n2)
    {
        for(int i=1;i<n2+1;i++)
        {
            for(int j=n2-i;j>-1;j--)
            {
                Console.Write(" ");
            }
            for(int k=0;k<i;k++)
            {
               Console.Write("*");  
            }
            Console.Write("\n");
        }
    }
}
