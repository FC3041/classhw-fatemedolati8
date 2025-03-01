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
            int* newlist=(int*)malloc(sizeof(int)*m_size);
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
        int count_n(int n)
        {
            int count=0;
            for(int i=0;i<m_size;i++)
            {
                if(m_pnums[i]==n)
                {
                    count++;
                }
            }
            return count;
        }
        void del(int n)
        {
            int* newlist=(int*)malloc(sizeof(int) * (m_size-1));
            int j=0;
            for(int i=0;i<m_size;i++)
            {
                if(m_pnums[i]!=n)
                {
                    newlist[j]=m_pnums[i];
                    j++;
                }
            }
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
    cout<<"pop: "<<pop<<endl;
    cout<<"list after append 3 :";
    list2.append(3);
    list2.print_list();
    cout<<"the number of 3 in list : ";
    cout<<list2.count_n(3);
    
}