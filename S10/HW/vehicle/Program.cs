namespace vehicle;

class Program
{
    static void Main(string[] args)
    {
        I_vehicle[] vehicles=new I_vehicle[]
        {
            new bike("bargh"),
            new car("gaz"),
            new bus("benzin",25),
        };
    
    int c;
    string t;
    double co;
    double s;

    for(int i=0;i<vehicles.Length;i++)
    {
        c=vehicles[i].capacity();
        t=vehicles[i].type();
        co=vehicles[i].Pollutant();
        s=vehicles[i].area();
        System.Console.WriteLine($"The {t} capacity is {c}");
        System.Console.WriteLine($"The {t} produces {co} grams of CO2 per kilometer");
        System.Console.WriteLine($"The {t} occupies {s} square meters of space.");
    }
    
}
}