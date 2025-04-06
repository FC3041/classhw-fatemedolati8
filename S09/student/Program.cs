namespace student;

class Program
{

    static public void register_student(string[] list)
    {
        Student s=Student.parse_student(list);
        string[] list2=new string[1];
        list2[0]=s.to_string();
        File.AppendAllLines("student.txt",list2);
        

    }    
    static void Main(string[] args)
    {
        if(args[0]=="register")
        {
            register_student(args);
        }
        if(args[0]=="list")
        {
            string[] lines=File.ReadAllLines("student.txt");
            for(int i=0;i<lines.Length;i++)
            {

                System.Console.WriteLine($"{i+1} => "+lines[i]);
            }
        }
    }
    class Student
    {
        public string m_fname;
        public string m_lname;
        public int m_stdid;


        Student(string name,string lname,int stdid)
        {
            m_fname=name;
            m_lname=lname;
            m_stdid=stdid;

        }
        public static Student parse_student(string[] list)
        {
            string fname=list[1];
            string lname=list[2];
            int stdid=int.Parse(list[3]);
            return new Student(fname,lname,stdid);

        }
        public string to_string()=>$"Firstname : {m_fname} , Lastname: {m_lname} , Student_Number: {m_stdid}";
    }
    
}
