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
            cout << m_pnums[i];
            if (i != m_size - 1)
            {
                cout << " , ";
            }
        }
        cout << endl;
    }
    void erase(int index2, int* list)
    {
        int badi = list[index2 + 1];
        for (int i = index2; i < m_size; i++)
        {
            list[i] = badi;
            badi = list[i + 2];
        }
    }
    int max(int* list)
    {
        int max = 0;
        for (int i = 0; i < m_size; i++)
        {
            if (list[i] > max)
            {
                max = list[i];
            }
        }
        return max;
    }
    int min3(int* list, int* index,int len)
    {
        int min2 = max(list);
        for (int i = 0; i < len; i++)
        {
            if (min2 > list[i])
            {
                min2 = list[i];
                *index = i;
            }
        }

        return min2;
    }
    void sort()
    {
        int* newlist = (int*)malloc(sizeof(int) * m_size);
        for (int i = 0; i < m_size; i++)
        {
            newlist[i] = m_pnums[i];
        }
        int min;
        int index;
        int len = m_size;
        for (int i = 0; i < m_size; i++)
        {
            min = min3(newlist, &index,len);
            m_pnums[i] = min;
            erase(index, newlist);
            len--;
        }

    }
};

int main()
{
    int nums[10] = { 1,4,3,2,5,19,11,21,55,23 };
    list list(10, nums);
    list.print_list();
    list.sort();
    list.print_list();


}
