using System;
class program 
{    static void Main(string[] args)
        {
            RocketShipFactored();
        }
    static void RocketShipFactored()
    {
        head();
        line();
        body();
        line();
        body();
        line();
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
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");        
    }
    static void line()
    {
        Console.WriteLine("+-------+");
    }
}

        
