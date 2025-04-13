namespace Coordinates.Test;
using static System.Math;
[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void polarcor_test()
    {
        polarcor v1=new polarcor(3,90);
        polarcor v2=new polarcor(4,180);
        polarcor vsum=v1.Add(v2);
        polarcor result=new polarcor(5,Math.Atan(-0.75));
        double a=v1.magnitude();
        Assert.AreEqual(a,3);
        Assert.AreEqual(vsum,result);
        // Assert.AreEqual(vsum.teta,result.teta);
    }
}
