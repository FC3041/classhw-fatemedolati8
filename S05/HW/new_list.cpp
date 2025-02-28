#include<iostream>
using namespace std;


class list
{
public:
    int m_size;
    int* m_pnums;
    int m_capacity;

    list(int size, int* nums) :m_size(size)
    {
        m_capacity = m_size;
        m_pnums = (int*)malloc((sizeof(int)) * m_size);
        for (int i = 0; i < m_size; i++)
        {
            m_pnums[i] = nums[i];
        }
    }
    void print_list()
    {
        for (int i = 0; i < m_size; i++)
        {
            cout << m_pnums[i] ;
            if(i!=m_size-1)
            {
                cout<<" , ";
            }
        }
        cout << endl;
    }
    void append(int n)
    {
        m_size++;
        resize();
        m_pnums[m_size - 1] = n;
    }
    void resize()
    {
        if (m_capacity < m_size)
        {
            m_capacity *= 2;
            int* newlist = (int*)malloc(sizeof(int) * m_capacity);
            for (int i = 0; i < m_size; i++)
            {
                newlist[i] = m_pnums[i];
            }
            free(m_pnums);
            m_pnums = newlist;
            // free(newlist);
        }


    }
    void insert(int index, int n)
    {
        int c=m_pnums[m_size-1];
        m_size++;
        resize();
        int badi = m_pnums[index]; 
        m_pnums[index] = n;
        int badi2 = m_pnums[index + 1];
        m_pnums[index + 1] = badi;
        for (int j = index + 2; j < m_size; j++)
        {
            m_pnums[j] = badi2;
            badi2 = m_pnums[j + 1];
        }
        m_pnums[m_size-1]=c;
    }

    int size()
    {
        return m_size;
    }
    int count_n(int n)
    {
        int count = 0;
        for (int i = 0; i < m_size; i++)
        {
            if (m_pnums[i] == n)
            {
                count++;
            }
        }
        return count;
    }
    void erase(int index)
    {
        int c=m_pnums[m_size-1];
        m_size--;
        int badi=m_pnums[index+1];
        for (int i =index ; i < m_size; i++)
        {
            m_pnums[i]=badi;
            badi=m_pnums[i+2];
        }
        m_pnums[m_size-1]=c;
        m_pnums[m_size]=0;
    }
    int pop()
    {
        int p = m_pnums[m_size - 1];
        resize();
        return p;
    }
    int capacity()
    {
        return m_capacity;
    }
    void clear()
    {
        for(int i=0;i<m_size;i++)
        {
            m_size=0;
        }
    }
};
int main()
{
    int nums[5]={1,2,3,4,5};
    list list(5,nums);
    cout<<"list : ";
    list.print_list();
    list.append(6);
    cout<<"list after append 6 : ";
    list.print_list();
    cout<<"size list : "<<list.size()<<endl;
    list.insert(3,2);
    cout<<"list after insert 2 in index 3 : ";
    list.print_list();
    list.erase(3);
    cout<<"list after erase the number in the index 3 : ";
    list.print_list();
    cout<<"list capacity : "<< list.capacity()<<endl;
    list.clear();
    cout<<"list after clear : ";
    list.print_list();
    list.append(6);
    cout<<"list after append 6 : ";
    list.print_list();
}
