using System;
namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calculate the area and perimiter of cicle
            Console.WriteLine("Enter the radius of the circle:");
            double r = double.Parse(Console.ReadLine());

            const double pi = 3.142;
            double P = 2 * pi * r;
            double A = pi * r * r;
            Console.WriteLine($"The Perimeter of the circle is {P}");
            Console.WriteLine($"The Area of the circle is {A}");
            
            //determine the securite key
            Console.WriteLine("Enter the security key:");
            string key = Console.ReadLine();
            string accesslevelgranted;

            if (key=="s1gN@I")
            {
                accesslevelgranted = "Generaluser";
            }
            else if (key == "coDe3%4")
            {
                accesslevelgranted = "Admin";
            }
  
            else
            {
                accesslevelgranted = "Super user";
            }
            // determine marks of the students
            Console.WriteLine("Enter the student's score:");
            double score = double.Parse(Console.ReadLine());

            if (score >= 50)
            {
                Console.Write("The student passes");

                if (score >= 90)
                {
                    Console.WriteLine(" gets a high distiction ");

                }
                else if (score >= 75)
                {
                    Console.WriteLine(" ges a distiction ");
               
                }
            }
            else
            {
                Console.Write("The student fails");
            }
            if (score <= 30)
                {
                    Console.WriteLine(" strongly advised to retake the course ");
                }
            // determine amount that will be paid by customer 
            Console.WriteLine("Enter the age of the curstomer");
            double age =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the monthly income");
            double monthlyincome =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of night");
            double numberofnight =double.Parse(Console.ReadLine());
            double discount = 0;
            double costpernight = 1500;
            double amount = numberofnight * costpernight;

            if (age >= 65)
            {
                discount += 0.20;

                if (monthlyincome < 30000)
                {
                    discount += 0.10;
                }
            }
            else 
            {
                discount += 0;

                if (monthlyincome < 50000)
                {
                    discount += 0.15;
                }

            }
            double finalamount = amount - (amount*discount);
            Console.WriteLine($"The amount that will be paid by customer is{finalamount} ");
            // print the column of the stars incrementing 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 1+i-1; j++)
                {
                    Console.Write("*");


                }
                Console.WriteLine();
            }
        }
    }
}
