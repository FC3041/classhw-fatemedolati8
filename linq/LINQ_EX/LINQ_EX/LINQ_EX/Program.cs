using System.Reflection.Metadata.Ecma335;

namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var data = File.ReadAllLines("C:\\git\\classhw\\S22\\LINQ_EX\\LINQ_EX\\LINQ_EX\\data.csv")
            .Skip(1)
            .Select(l =>
            {
                string[] harchi = l.Split(',');
                string noomid = harchi[0];
                int year = int.Parse(harchi[1]);
                string rigeon = harchi[2];
                string country = harchi[3];
                string gender = harchi[4];
                double value = double.Parse(harchi[5]);
                double numeric = double.Parse(harchi[6]);
                return (noomid: noomid, year: year, rigeon: rigeon, country: country, gender: gender, value: value, numeric: numeric);
            }
            )
            .Where(t => (t.country.Contains("Iran")) && (t.noomid.Contains("birth")) && (t.gender.Contains("Both")))
            .OrderBy(t => t.numeric);


        data.ToList().ForEach(l => System.Console.WriteLine(l));
        Console.WriteLine("Query 1");
        //
        //
        
        data.Join(data,
            (f1) => (f1.country, f1.noomid, f1.gender),
            (f2) => (f2.country, f2.noomid, f2.gender),
            (f1, f2) => (country: f1.country, noomid: f1.noomid, gender: f1.gender, numeric1: f1.numeric, numeric2: f2.numeric,
            year1: f1.year, year2: f2.year, rigeon1: f1.rigeon, rigeon2: f2.rigeon, value1: f1.value, value2: f2.value))
            .GroupBy(t => t.country)
            .Select(g =>
            {
                var max_ = g.MaxBy(t => Math.Abs(t.numeric1 - t.numeric2));
                return (country: g.Key, maxe: max_);
            })
        .ToList().ForEach(l => System.Console.WriteLine(l.maxe));
        Console.WriteLine(Math.Abs(data.First().numeric-data.Last().numeric));
        Console.WriteLine("Query 2");
        //
        //
        Console.WriteLine();

        int n = 1;
        var data2 = File.ReadAllLines("C:\\git\\classhw\\S22\\LINQ_EX\\LINQ_EX\\LINQ_EX\\data.csv")
            .Skip(1)
            .Select(l =>
            {
                string[] harchi = l.Split(',');
                string noomid = harchi[0];
                int year = int.Parse(harchi[1]);
                string rigeon = harchi[2];
                string country = harchi[3];
                string gender = harchi[4];
                double value = double.Parse(harchi[5]);
                double numeric = double.Parse(harchi[6]);
                return (noomid: noomid, year: year, rigeon: rigeon, country: country, gender: gender, value: value, numeric: numeric);
            }
            )
            .Where(t => (t.gender == "Both") && t.noomid.Contains("birth"))
            .GroupBy(g => g.country)
            .Select(g =>
            {
                var max = g.MaxBy(t => t.numeric);
                var min = g.MinBy(t => t.numeric);
                return (country: g.Key, min: min,dif:Math.Abs(max.numeric-min.numeric) );
            })
            .OrderByDescending(g=>g.dif)
            .Select(g=>(country:g.country,year:g.min.year,min_n:g.min.numeric,diff:g.dif));
        data2.ToList().ForEach(l => System.Console.WriteLine($"{n++} {l}"));

        //Query 3
        Console.WriteLine("Query 3");
        //
        //
        Console.WriteLine();
        var data3 = File.ReadAllLines("C:\\git\\classhw\\S22\\LINQ_EX\\LINQ_EX\\LINQ_EX\\data.csv")
              .Skip(1)
            .Select(l =>
            {
                string[] harchi = l.Split(',');
                string noomid = harchi[0];
                int year = int.Parse(harchi[1]);
                string rigeon = harchi[2];
                string country = harchi[3];
                string gender = harchi[4];
                double value = double.Parse(harchi[5]);
                double numeric = double.Parse(harchi[6]);
                return (noomid: noomid, year: year, rigeon: rigeon, country: country, gender: gender, value: value, numeric: numeric);
            }
          );
        var data4 = data3.Where(t => t.gender == "Male");
        var data5 = data3.Where(t => t.gender == "Female");
        int n1 = 1;
        data4.Join(data5,
            (f1) => (f1.country, f1.year),
            (f2) => (f2.country, f2.year),
            (f1, f2) =>
            (country: f1.country, year: f1.year , numeric_ma: f1.numeric, numeric_fe: f2.numeric,diff: Math.Abs(f1.numeric - f2.numeric))
            )
            .GroupBy(g => g.country)
            .Select(g=>
            {
                var maxdif = g.MaxBy(t => t.diff);
                return (country: g.Key, maxdif: maxdif);
            }
            )
            .OrderByDescending(g=>g.maxdif.diff)
            .ToList().ForEach(l => System.Console.WriteLine($"{n1++} {l}")); ;
        //Query 4
        Console.WriteLine("Query 4");
        //
        //
        Console.WriteLine();

    }
}
