using System; 
// class one 
   public class Employee  
    {  
       public float salary = 40000;  
   } 
   // class two
   public class Programmer: Employee  
   {  
       public float bonus = 10000;  
   }  
    // Inheritance
   class Inheritance{  
       public static void Main(string[] args)  
        {  
            Programmer one = new Programmer();  
  
            Console.WriteLine("Salary: " + one.salary);  
            Console.WriteLine("Bonus: " + one.bonus);
        }  
    }