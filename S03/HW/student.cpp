#include<iostream>
using namespace std;
#include<string.h>
class Student
{
    public:
        int m_stdnum;
        char m_lastname[20];
        char m_firstname[20];
        int m_coursepassed;
        int m_credits[40];
        double m_grades[40];
        char* m_coursename[40];
    
        Student(int stdnum, const char* fname, const char* lname)
        {
            m_stdnum=stdnum;
            strcpy(m_firstname,fname);
            strcpy(m_lastname,lname);
        }
        ~Student()
        {}
        double getgpa()
        {
            double sumgrade=0;
            double sumcredits=0;
            for(int i=0;i<m_coursepassed;i++)
            {
                sumgrade+=m_grades[i]*m_credits[i];
                sumcredits+=m_credits[i];
            }
            return sumgrade/sumcredits;
        }
        void student_print()
        {
            cout<<m_firstname<<" "<<m_lastname<<"    "<<m_stdnum<<endl;
        }
        void list_course()
        {
            for(int i=0;i<m_coursepassed;i++)
            {
                cout<<m_coursename[i]<<" : "
                <<m_credits[i]<<" : "
                <<m_grades[i]<<endl;
            }
        }
        void register_course(int credit,const char* name,int grade)
        {
            m_credits[m_coursepassed]=credit;
            m_grades[m_coursepassed]=grade;
            char* name2=new char[strlen(name)+1];
            strcpy(name2,name);
            m_coursename[m_coursepassed]=name2;
            m_coursepassed++;
        }
};

int main()
{
    int stdnum;
    char* fname=new char[20];
    char* lname=new char[20];
    cout<<"stdnumber?";
    cin>>stdnum;
    cout<<"first name?";
    cin>>fname;
    cout<<"last name?";
    cin>>lname;
    const char* fname2=fname;
    const char* lname2=lname;
    Student s=Student(stdnum,fname2,lname2);
    s.m_coursepassed = 0;
    char bufc[20];
    double grade;
    int credits;
    while(true)
    {
        cout << "course name?" ;
        cin >> bufc ;
        if (*bufc == 'A')
            break;
        cout << "course credits?" ;
        cin >> credits ;
        cout << "course grade?" ;
        cin >> grade ;
        s.register_course(credits, bufc, grade);
    }
    s.list_course();
    cout << s.getgpa() << endl;
    return 0;
}


