using System;

namespace ConsoleApp_Trial3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your marks : ");
                string Input = Console.ReadLine();
                int a = int.Parse(Input);
                if ((a >= 0) && (a <= 100))
                {
                    String Max_Marks = Max_Grade(a);
                    Console.WriteLine("Your Grade for this class is: " + Max_Marks);
                    Console.WriteLine("Please click a key to exit");
                    Console.ReadKey(true);
                    //int heart_rate = (220 - a);
                }
            }//end of try
            catch
            {
                Console.WriteLine("There is an error");
                Console.WriteLine("Please click a key to exit");
                Console.ReadKey(true);
            }//end of catch
        }//end of main
        
        private static string Max_Grade(int marks)
            {
            if (marks <60)
            {
                return "F";
            }
            else if (marks >= 60&& marks<=62)
            { return "D";  }
            else if (marks >= 63 && marks<=66)
            { return "D+"; }
            else if (marks >= 67 && marks<=69)
            { return "C-"; }
           
            else if (marks >= 70 && marks <= 73)
            { return "C"; }
            else if (marks >= 74 && marks <= 76)
            { return "C+"; }
            
            else if (marks >= 77 && marks <= 79)
            { return "B-"; }
            else if (marks >= 80 && marks <= 83)
            { return "B"; }
            else if (marks >= 84 && marks <= 86)
            { return "B+"; }
            else if (marks >= 87 && marks <= 89)
            { return "A-"; }
            else if (marks >= 90 && marks <= 94)
            { return "A"; }
            else if (marks >= 95 && marks <= 100)
            { return "A+"; }
            else { return "NA"; }
          
        }//new method
    }
}
