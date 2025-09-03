using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
namespace E3;
public class Animal
{
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}

public class Dog:Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }
}

public class MyPointType1
{
    public int X { get; set; }
    public int Y { get; set; }
}
public struct MyPointType2
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class Comparer<T>where T:IComparable
{
    public Comparer(T a, T b)
    {
        this.a = a;
        this.b = b;
    }

    public T a { get; set; }
    public T b { get; set; }

    public T GetLarger()
    {
        if (a.CompareTo(b) > 0) { return a; }
        return b;
    }
}


public class Product:IComparable
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int CompareTo(object? obj)
    {
        Product product = (Product)obj;
        if(this.Price<product.Price)
        {
            return -1;
        }
        if (this.Price > product.Price)
        {
            return 1;
        }
        return 0;
    }
}


public class ResourceManager : IDisposable
{
    public ResourceManager()
    {
        IsDisposed = false;
    }

    public bool IsDisposed { get; set; }
    public void Dispose()
    {
        IsDisposed =true;
    }
}

public class LinqProblems
{
    public static List<int> FilterAndDouble(List<int> nums)
    {
        return nums.Where(n => n > 5).Where(n => n % 2 == 0).Select(n => n * 2).ToList();
    }
    public static Dictionary<string,int>  GetTotalAmountByCategory(List<Sale> sales)
    {
        return sales.GroupBy(s => s.Category).ToDictionary(g => g.Key, g => g.Sum(s => s.Amount));
    }
}

public class Sale
{
    public string Category { get; set; }
    public int Amount { get; set; }
}

public class Money: IEquatable<Money>
{
    public Money(int amount, string str)
    {
        Amount = amount;
        this.str = str;
    }

    public int Amount { get; set; }
    public string str { get; set; }

    public bool Equals(Money? other)
    {
        var money = (Money)other;
        if (this==money)
        {
            return true;
        }
        return false;
    }

    public static Money operator+(Money m1,Money m2)
    {
        return new Money(m1.Amount + m2.Amount, m1.str);
    }
    public static bool operator ==(Money m1, Money m2)
    {
        if(m1.Amount==m2.Amount && m1.str==m2.str)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(Money m1, Money m2)
    {
        if (m1.Amount != m2.Amount || m1.str != m2.str)
        {
            return true;
        }
        return false;
    }
}

public class DelegateProblems
{

    public static Func<string,string> ToUpper = new Func<string,string>((string x) => x.ToUpper());
    public static Func<string,string> ToLower = new Func<string, string>((string x) => x.ToLower());
    public static string ProcessString(string str, Func<string,string> str2)
    {
        return str2.Invoke(str);
    }

}



public class LambdaProblems
{
    public static Func<string,int> GetStringLengthCalculator()
    {
        return new Func<string, int>((string x) => x.Length);
    }
}

public class Publisher
{
    public List<string> me = new();
    public static bool is_changed = true;
    public Publisher()
    {
    }
    public void RaiseEvent(string s33)
    {

    }
    public static void unsub()
    {
        is_changed = false;
    }
}
public class Subscriber
{
    public List<string> ReceivedMessages = new();
    public Func<string> 
    public Subscriber(Publisher publisher)
    {

    }

    public void re(string s)
    {
        ReceivedMessages.Add(s);
    }
    public void Unsubscribe()
    {
        Publisher.unsub();
    }
}

public class Closures
{
    //public static int n { get; set; } = 1;
    public static Func<int> CreateCounter()
    {
        int n=1;
        return new Func<int>(() =>n++);
    }
}

public class SafeCounter
{
    public int Count;
    public object lock_=new();
    public SafeCounter()
    {
    }

    public void Increment()
    {
        lock(lock_)
        {
            Count++;
        }
        
    }
}

public class DataService
{
    public DataService()
    {
    }

    public async  Task<string> FetchDataAsync(string str)
    {
        await Task.Delay(20000);
        return "Data for "+str;
    }

}
//public class Repository<T> where T: IEntity<T>
//{

//}

public interface IStage<T>
{
    public string Handle(T s);


}

//public class TrimStage: IStage<string>
//{
//    public IStage<string> stage;

//    public string Handle(string s)
//    {
//        if(stage==UpperStage )
//        {

//        }
//    }

//    public IStage<string>  SetNext(IStage<string> stage2)
//    {
//        stage = stage2;
//        return stage2;
//    }
//}
//public class UpperStage : IStage<string>
//{
//    public UpperStage()
//    {
//    }

//    public string Handle(string s)
//    {
//        throw new NotImplementedException();
//    }
//}
//public class SuffixStage : IStage<string>
//{
//    public SuffixStage(string s)
//    {
//    }

//    public string Handle(string s)
//    {
//        throw new NotImplementedException();
//    }
//}