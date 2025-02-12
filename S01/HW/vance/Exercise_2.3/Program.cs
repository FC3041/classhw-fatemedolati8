using System;
class Program
{
    static void Main(string[] args)
    {
        RocketShipLong();
    }
    static void RocketShipLong()
    {
        head();
        for(int i=0;i<4;i++)
        {
            body();
        }
        head();
    }
    static void head()
    {
       Console.WriteLine("    ^");
        Console.WriteLine("   /|\\");
        Console.WriteLine("  //|\\\\");
        Console.WriteLine(" ///|\\\\\\");
    }
    static void body()
    {
        Console.WriteLine("+-------+");
        for(int i=0;i<6;i++)
        {
            Console.WriteLine("+*******+");   
        }
             
    }
}
