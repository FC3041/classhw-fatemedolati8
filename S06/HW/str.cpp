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

        m_size = len(s);
        m_capacity = m_size;
        m_str = (char*)malloc(sizeof(char) * m_capacity);
        for (int i = 0; i < m_size; i++)
        {
            m_str[i] = s[i];
        }
        m_str[m_size] = 0;
    }
    string1()
    {

    }
    void assign(char* pch)
    {
        m_size = len(pch);
        m_capacity = m_size;

        m_str = (char*)malloc(sizeof(char) * m_size);
        for (int i = 0; i < m_size; i++)
        {
            m_str[i] = pch[i];
        }
        m_str[m_size] = 0;
    }
    int len(const char* pch)
    {
        int count = 0;
        while (*pch != 0)
        {
            count++; \
                pch++;
        }
        pch -= count;
        return count;
    }
    int size()
    {
        return m_size;
    }

    void print_string()
    {
        cout << m_str << endl;
    }
    void resize()
    {
        if (m_capacity < m_size)
        {
            m_capacity *= 2;
            char* newstr = (char*)malloc(sizeof(char) * m_capacity);
            for (int i = 0; i < m_size; i++)
            {
                newstr[i] = m_str[i];
            }
            free(m_str);
            m_str = newstr;
            // free(newstr);
        }

    }
    void Add(char* pch)
    {

        int l = len(pch);
        m_size += l;
        resize();
        for (int i = 0; i < l; i++)
        {
            m_str[m_size + i - l] = pch[i];
        }
        m_str[m_size] = 0;

    }
    void Add(string1 str3)
    {
        int l = len(str3.m_str);
        m_size += l;
        resize();
        for (int i = 0; i < l; i++)
        {
            m_str[m_size + i - l] = str3.m_str[i];
        }
        m_str[m_size] = 0;
    }
    bool checkSubstr(char* pch)
    {
        bool flag;
        for (int i = 0; i < m_size; i++)
        {
            flag = true;
            for (int j = 0; j < len(pch); j++)
            {
                if (m_str[i + j] != pch[j])
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                return true;
            }
        }
        return flag;
    }
};
int main()
{
    char pch[] = "fateme";
    string1 str(pch);
    cout << "normal str :";
    str.print_string();
    string1 str2;
    char pch2[] = "reyhane";
    str2.assign(pch2);
    cout << "str2 String value given by assign function : ";
    str2.print_string();
    char pch3[5] = "fate";
    bool flag = str.checkSubstr(pch3);
    cout << flag<<endl;
    char pch4[5] = "teme";
    flag = str.checkSubstr(pch4);
    cout << flag << endl;
    char pch5[5] = "temd";
    flag = str.checkSubstr(pch5);
    cout << flag << endl;
    char pch6[6] = "yhant";
    flag = str2.checkSubstr(pch6);
    cout << flag << endl;
    cout<< "str len: "<<str.size()<<endl;
    str.Add(str2);
    cout<<"str after Add str2 : ";
    str.print_string();

}