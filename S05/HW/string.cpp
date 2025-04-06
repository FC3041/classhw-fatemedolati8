#include<iostream>
using namespace std;
class string1
{
    public:
        char* m_str;
        int m_size;
        int m_capacity;
        string1(char* s)
        {
            
            m_size=len(s);
            m_capacity=m_size;
            m_str=(char*)malloc(sizeof(char)*m_capacity);
            for(int i=0;i<m_size;i++)
            {
                m_str[i]=s[i];
            }
            m_str[m_size]=0;
        }
        string1()
        {

        }
        void assign(char* pch)
        {
            m_size=len(pch);
            m_capacity=m_size;
            
            m_str=(char*)malloc(sizeof(char)*m_size);
            for(int i=0;i<m_size;i++)
            {
                m_str[i]=pch[i];
            }
            m_str[m_size]=0;
        }
        int len(const char* pch)
        {
            int count=0;
            while(*pch!=0)
            {
                count++;
                pch++;
            }
            pch-=count;
            return count;
        }
        int size()
        {
            int count=0;
            while(*m_str!=0)
            {
                count++;
                m_str++;
            }
            m_str-=count;
            return count;    
        }

        void print_string()
        {
            cout<<m_str<<endl;
        }
        void resize()
        {
            if(m_capacity<m_size)
            {
                m_capacity*=2;
                char* newstr=(char*)malloc(sizeof(char) * m_capacity);
                for(int i=0;i<m_size;i++)
                {
                    newstr[i]=m_str[i];
                }
                free(m_str);
                m_str=newstr;
                // free(newstr);
            }
            
        }
        void append(char* pch)
        {
            
            int l=len(pch);
            m_size+=l;
            resize();
            for(int i=0;i<l;i++)
            {
                m_str[m_size+i-l]=pch[i];
            }
            m_str[m_size]=0;

        }
        void append(string1 str3)
        {
            int l=len(str3.m_str);
            m_size+=l;
            resize();
            for(int i=0;i<l;i++)
            {
                m_str[m_size+i-l]=str3.m_str[i];
            }
            m_str[m_size]=0;    
        }
        const char* c_str()
        {
            const char* str2=m_str;
            return str2;
        }
};
int main()
{
    char pch[]="fateme";
    string1 str(pch);
    cout<<"normal str :" ;
    str.print_string();
    string1 str2;
    char pch2[]="reyhane";
    str2.assign(pch2);
    cout<<"str2 String value given by assign function : ";
    str2.print_string();
    char pch3[]=" sina";
    str.append(pch3);
    cout<<"str after append sina with a function whose input is char* : ";
    str.print_string();
    char pch4[]=" sana";
    string1 str3(pch4);
    str.append(str3);
    cout<<"str after append sana with a function whose input is object from string1 class : ";
    str.print_string();
    cout<<"str from c_str method : "<< str.c_str()<<endl;
    cout<<"str size : "<<str.size()<<endl;
}