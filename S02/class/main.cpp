#include<iostream>
#include<math.h>
using namespace std;
class point
{
    public:
        double x;
        double y;

        point(double t,double r)
        {
            x=t;
            y=r;
        }
};
void distance(point p1,point p2)
{
    double d=sqrt((p1.x-p2.x)*(p1.x-p2.x) + (p1.y-p2.y)*(p1.y-p2.y));
    cout<<"d:"<<d<<endl;
    // return d;

}
int main()
{
    point p1(4,3);
    // p1.x=4;
    // p1.y=3;
    point p2(-1,5);
    // p2.x=-1;
    // p2.y=5;
    distance(p1,p2);
    // cout<<"p1.x:"<<p1.x<<endl;
    // int a;
    // cin>>a;
    // cout<<"a:"<<a<<endl;


    return 0;
}