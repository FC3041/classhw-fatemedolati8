namespace revers;

class Program
{
    static void revers_jomle_kalame(string str,out string strout)
    {
        strout="";
        foreach(char s in str)
        {
            strout=s+strout;
        }
    }
    static int count_space(string str)
    {
        int count=0;
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]==' ')
            {
                count++;
            }
        }
        return count+1;
    }
    static void revers_jomle(string str,out string strout)
    {
        strout="";
        int n=count_space(str);
        List<string> kalamat = new List<string>();
        string kalame="";
        foreach(char s in str)
        {
            if(s!=' ')
            {
                kalame+=s;
            }
            
            if(s==' ')
            {
                kalamat.Add(kalame);
                kalame="";
            }

        }
        kalamat.Add(kalame);
        for(int i=n-1;i>-1;i--)
        {
            strout+=kalamat[i];
            strout+=' ';
        }

    }
    static void Main(string[] args)
    {
        string strrev;
        revers_jomle_kalame("salam khobi?",out strrev);
        System.Console.WriteLine(strrev);
        string strrev2;
        revers_jomle("salam khobi? chetori che khbar? fisnkfi",out strrev2);
        System.Console.WriteLine(strrev2);
    }
}
