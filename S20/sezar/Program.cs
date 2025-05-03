namespace sezar;

class Program
{
    static void Main(string[] args)
    {

        string x="AbcDefGHijklmNopQRSTuvwXyZ";
        string s1=x.Encoder();
        string s2=x.Decoder();
        System.Console.WriteLine(s1);
        System.Console.WriteLine(s2);


    }
}
