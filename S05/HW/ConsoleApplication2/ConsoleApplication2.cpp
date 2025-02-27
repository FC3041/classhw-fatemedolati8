#include<iostream>
using namespace std;
class string1
{
public:
    char* m_str;
    int m_size;
    int m_capacity;
    string1(const char* s)
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
    void assign(const char* pch)
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
            count++;
            pch++;
        }
        pch -= count;
        return count;
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
            free(newstr);
        }

    }
    void append(const char* pch)
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
    void append(string1 str)
    {
        //int l = len(str.m_str);
        //m_size += l;
        //resize();
        //for (int i = 0; i < l; i++)
        //{
        //    m_str[m_size + i - l] = str.m_str[i];
        //}
        //m_str[m_size] = 0;
    }

};
int main()
{
    const char* pch = "fateme";
    string1 str(pch);
    str.print_string();
    string1 str2;
    str2.assign("reyhane");
    str2.print_string();
    str.append("sina");
    str.print_string();
    str.append(str2);
    str.print_string();
}