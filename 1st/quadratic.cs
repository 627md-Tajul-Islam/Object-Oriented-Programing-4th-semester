using System;
public class Quadtest
{
    public static void Main(string[] args)
    {
    int a,b,c,d;
    double x,x1,x2 ;
    Console.Writeline("enter the value of a");
    a=Convert.ToInt16(Console.Readline( ));
    Console.Writeline("enter the value of b");
    b=Convert.ToInt16(Console.Readline( ));
    Console.Writeline("enter the value of c");
    c=Convert.ToInt16(Console.Readline( ));
    d=b*b-4*a*c;
    if(d>0)
    {
    x1=(-b+math.sqrt(d))/(2*a);
    x2=(-b-math.sqrt(d))/(2*a);
    Console.Writeline("x1="+x1+"x2="+x2);
    }
    else if(d==0)
    {
    x=-b/(2*a);
    Console.Writeline("x="+x);
    }
    else
    Console.Writeline("root are imaginary ");
    Console.Readkey( );
    }
}