// for 
for (condition) {
    // do something
}

using System;
namespace inherit
{
public class A
{
    public static void Main(string[] args);
    public int a=20, b=30,sum;
    void summation()
    {
        sum = a + b;
        console.Writeline(sum);
    }
}
class B:A
{
    public int sub;
    void subtraction()
    {
        sub = a - b;
        console.writeline(sub);
    }
}
}