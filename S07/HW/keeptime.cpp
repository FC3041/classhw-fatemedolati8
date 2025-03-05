#include<iostream>
#include<windows.h>
#include<string>
using namespace std;
class keeptime 
{
    unsigned long long int m_starttime;
    unsigned long long int m_finishtime;
    string m_name;

    public:
    keeptime(string name):m_name(name)
    {
        m_starttime=GetTickCount64();
        // cout<<m_starttime<<endl;
    }
    ~keeptime()
    {

        m_finishtime=GetTickCount64();
        // cout<<m_finishtime<<endl;
        cout<<m_name <<" : " <<m_finishtime-m_starttime<<endl;

    }
    
};
int main()
{
    string name="for loop";
    keeptime k22(name);
    int s=0;
    for(int i=0;i<1000000000;i++)
    {
        s+=7;
    }

}