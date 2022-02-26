using System;
public class Quadtest
{
    public static void Main(string[] args)
    {
    int a,b,c,d;
    double x,x1,x2 ;
    console.Writeline("enter the value of a");
    a=convert.ToInt16(console.Readline( ));
    console.Writeline("enter the value of b");
    b=convert.ToInt16(console.Readline( ));
    console.Writeline("enter the value of c");
    c=convert.ToInt16(console.Readline( ));
    d=b*b-4*a*c;
    if(d>0)
    {
    x1=(-b+math.sqrt(d))/(2*a);
    x2=(-b-math.sqrt(d))/(2*a);
    console.Writeline("x1="+x1+"x2="+x2);
    }
    else if(d==0)
    {
    x=-b/(2*a);
    console.Writeline("x="+x);
    }
    else
    Console.Writeline("root are imaginary ");
    Console.Readkey( );
    }
}