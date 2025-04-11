namespace s13con;

class Program
{  
    public static void PrintPersons(IPerson<int>[] ps)
    {
        foreach(var p in ps)
            Console.WriteLine(p);
    }    
    public static void Main(string[] args)
    {
        Student [] students = new Student[] { 
            new Student() {
                FirstName="Nali",
                LastName="Hamedi",
                GPA = 18.5,
                Id = 12
            },
            new Student() {
                FirstName="Mali",
                LastName="Zamedi",
                GPA = 16.5,
                Id = 5
            },
            new Student() {
                FirstName="Zali",
                LastName="Amedi",
                GPA = 19.5,
                Id = 1
            },
        };
        System.Console.WriteLine("list:");
        PrintPersons(students);
        System.Console.WriteLine("----------------");

        System.Console.WriteLine("sort firstname:");
        MySort(students, PersonComparers.PersonFirstNameComparer);
        PrintPersons(students);
        System.Console.WriteLine("----------------");

        System.Console.WriteLine("sort lastname:");
        MySort(students, PersonComparers.PersonLastNameComparer);
        PrintPersons(students);
        System.Console.WriteLine("----------------");

        System.Console.WriteLine("sort fullname:");
        MySort(students, PersonComparers.PersonFullNameComparer);
        PrintPersons(students);
        System.Console.WriteLine("----------------");
        
        System.Console.WriteLine("sort Id:");
        MySort(students, PersonComparers.PersonIdComparer);
        PrintPersons(students);
    

    }

    private static void MySort(IPerson<int>[] persons, IComparer<IPerson<int>> cmp)
    {
        for(int i=0; i<persons.Length; i++)
            for(int j=i+1; j<persons.Length;j++)
                if (cmp.Compare(persons[i], persons[j]) > 0)
                    swap<IPerson<int>>(persons, i, j);
    }

    private static void swap<T>(T[] items, int i, int j)
    {
        T tmp = items[i];
        items[i] = items[j];
        items[j] = tmp;
    }

}
