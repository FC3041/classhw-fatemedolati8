#include<iostream>
#include<math.h>
using namespace std;

class point
{
    public:
        double a;
        double b;
    point(double r,double t)
    {
        a=r;
        b=t;
    }
};
class c
{
    public:
        double x;
        double y;
        double r;


        c(double a,double b,double l)
        {
            x=a;
            y=b;
            r=l;
        }
        double p()
        {
            return (2*3.14)*r;
        }
        double s()
        {
            return 3.14*(r*r);
        }
        double d_markaz(c c2)
        {
            double d=sqrt((x-c2.x)*(x-c2.x)+(y-c2.y)*(y-c2.y));
            return d;
        }
        bool is_in(point p)
        {
            double d=sqrt((p.a-x)*(p.a-x)+(p.b-y)*(p.b-y));
            if(d<r)
            {
                return true;
            }
            return false;
        }
        double d_point(point p)
        {
            double d=sqrt((p.a-x)*(p.a-x)+(p.b-y)*(p.b-y));
            return d;
        }
};
int main()
{
    c c1=c(2,2,4);
    cout<<"c1 --> x: "<<c1.x<<" y: "<<c1.y<<" r: "<<c1.r<<endl;
    cout<<"P = "<< c1.p()<<endl;
    cout<<"S = "<< c1.s()<<endl;
    c c2=c(1,1,4);
    cout<<"c2 --> x: "<<c2.x<<" y: "<<c2.y<<" r: "<<c2.r<<endl;
    cout<<"The distance from the center of the circle of c2 to c1 = "<< c1.d_markaz(c2)<<endl;
    point p=point(1,3);
    cout<<"p --> x: "<<p.a<<" y: "<<p.b<<endl;
    bool r=c1.is_in(p);
    if(r==true)
    {
        cout<<"The point p is inside the circle"<<endl;
    }
    if(r==false)
    {
        cout<<"The point p is not inside the circle"<<endl;
    }
    cout<<"The distance from point p to the center of circle c1 = "<<c1.d_point(p)<<endl;
}