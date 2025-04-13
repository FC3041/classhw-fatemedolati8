using System;
using static System.Math;
using System.IO;
using System.Numerics;
using System.Diagnostics;




public class polarcor :IComparable<polarcor>,IEquatable<polarcor>
{
    public double r { get; set; }
    public double teta {get;set;}
    public polarcor(double r_,double teta_)
    {
        this.r=r_;
        this.teta=((teta_*(Math.PI))/180);
    }
    public polarcor Add(polarcor v)
    {
        double x1=this.r*Math.Cos(this.teta);
        double x2=v.r*Math.Cos(v.teta);
        double y1=this.r*Math.Sin(this.teta);
        double y2=v.r*Math.Sin(v.teta);
        double x=x1+x2;
        double y=y1+y2;
        return new polarcor(Math.Sqrt((x*x)+(y*y)),Math.Atan(y/x));
    }
    public double magnitude()
    {
        double x=this.r*Math.Cos(this.teta);
        double y=this.r*Math.Sin(this.teta);
            return Math.Sqrt((x*x)+(y*y));

    }

    public int CompareTo(polarcor? other)
    {
        polarcor obj = other as polarcor;
        if(obj!=null)
        {
            return this.magnitude().CompareTo(obj.magnitude());
        }
        return 0;
    }

    public bool Equals(polarcor? other)
    {
        polarcor obj = other as polarcor;
        if(obj!=null)
        {
            return (this.r == obj.r) && (this.teta == this.teta);
        }
        return false;
    }
}