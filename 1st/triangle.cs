using System;

public class Program {
  public static void Main() {
    float baseSize, height, area;

    Console.WriteLine("Enter the base size of the triangle :");
    baseSize = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter the height of the triangle :");
    height = float.Parse(Console.ReadLine());

    area = (baseSize * height) / 2;
    Console.WriteLine("Area : " + area);
  }
}