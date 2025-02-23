#include<iostream>
using namespace std;


class list
{
    public:
        int m_size;
        int* m_pnums;

        list(int size,int* nums):m_size(size)
        {
            m_pnums=(int*)malloc((sizeof(int))*m_size);
            for(int i=0;i<m_size;i++)
            {
                m_pnums[i]=nums[i];
            }
        }
        void print_list()
        {
            for(int i=0;i<m_size;i++)
            {
                cout<<m_pnums[i]<<" , ";
            }
            cout<<endl;
            
        }
        void append(int n)
        {
            resize(m_size+1);
            m_pnums[m_size-1]=n;
        }
        void resize(int newsize)
        {
            m_size=newsize;
            int* newlist=(int*)malloc(sizeof(int)*newsize);
            for(int i=0;i<m_size;i++)
            {
                newlist[i]=m_pnums[i];
            }
            free(m_pnums);
            m_pnums=newlist;
            free(newlist);

        }
        void count()
        {
            cout<<m_size<<endl;
        }
        void del(int n)
        {
            int* newlist=(int*)malloc(sizeof(int) * (m_size-1));
            for(int i=0;i<m_size;i++)
            {
                if(m_pnums[i]!=n)
                {
                    *newlist=m_pnums[i];
                    newlist++;
                }
            }
            newlist-=m_size-1;
            m_size-=1;
            free(m_pnums);
            m_pnums=newlist;
            free(newlist);
        }
        int pop()
        {
            int p=m_pnums[m_size-1];
            resize(m_size-1);
            return p;
        }
};
int main()
{
    int nums[5] = {1,2,3,4,5};
    list list2(5, nums);
    cout<<"list: ";
    list2.print_list();
    cout<<"list after append 8 :";
    list2.append(8);
    list2.print_list();
    cout<<"count :";
    list2.count();
    list2.del(2);
    cout<<"list after delete 2 : ";
    list2.print_list();
    int pop=list2.pop();
    cout<<"list after pop :";
    list2.print_list();
    cout<<"pop: "<<pop;
    
}