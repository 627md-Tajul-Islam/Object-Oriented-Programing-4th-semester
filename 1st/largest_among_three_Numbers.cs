using System;
public class largest
{ 
    public static void Main(string[] args)
    {
       int num1, num2, num3;
         num1 = 100; num2 = 20; num3 = 50;
        if (num1 > num2) {
            if (num1 > num3) {
               Console.Write("Number one is the largest\n");
            }
      }
        if (num2 > num1) {
            if (num2 > num3) {
               Console.Write("Number two is the largest\n");
            }
      }
        if (num3 > num1) {
            if (num3 > num2) {
               Console.Write("Number three is the largest\n");
            }
      }
    }
}