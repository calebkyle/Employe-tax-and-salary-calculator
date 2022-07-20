using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_tax_and_salary_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE TAX & SALARY CACULATOR version 1.0.0");

           

            Console.WriteLine("\n Can users please input their names\n");
            
         Console.WriteLine("First name");
            string FirstName = Console.In.ReadLine().ToUpper();

            Console.WriteLine("\nLast name ");
            string LastName = Console.In.ReadLine().ToUpper();

            string FullName = FirstName +" "+ LastName;
            Console.WriteLine("\n Welcome"+" "+ FullName);


            double tax1, afterRelieve, takehome, relieve;

            Console.WriteLine("\nPlease write input your salary");

            int salary = Convert.ToInt32(Console.In.ReadLine());


            if (salary < 50000)
            {
                tax1 = salary * 12 / 100;
                Console.WriteLine("Your tax is = {0}\t ", tax1);

                relieve = tax1 - 4605;
                Console.WriteLine("Your relieve is = {0}\t ", relieve);

                takehome = salary - relieve;
                Console.WriteLine("Your Take Home is = {0}\t ", takehome);





            }

            else if (salary < 500000)
            {

                tax1 = salary * 18 / 100;
                Console.WriteLine("Your tax is = {0}\t ", tax1);

                relieve = tax1 - 7230;
                Console.WriteLine("Your relieve is = {0}\t ", relieve);

                takehome = salary - relieve;
                Console.WriteLine("Your Take Home is = {0}\t ", takehome);


            }

            else if (salary >= 500000)
            {
                tax1 = salary * 25 / 100;
                Console.WriteLine("Your tax is = {0}\t ", tax1);

                relieve = tax1 - 10050;
                Console.WriteLine("Your relieve is = {0}\t ", relieve);

                takehome = salary - relieve;
                Console.WriteLine("Your Take Home is = {0}\t ", takehome);

            }

            else

                return;

            Console.WriteLine("Do you want to try again[Y or N].");
            string answer = Console.ReadLine().ToUpper();




            while (answer == "Y")// answer == "N")
            {


                Console.WriteLine("\n Can users please input their names\n");

                Console.WriteLine("First name");
                 Console.In.ReadLine().ToUpper();

                Console.WriteLine("\nLast name ");
                 Console.In.ReadLine().ToUpper();

               
                Console.WriteLine("\n Welcome" + " " + FullName);




                //double tax1, relieve, takehome;

                Console.WriteLine("\nPlease write input your salary");

                 Convert.ToInt32(Console.In.ReadLine());


                if (salary < 50000)
                {
                    tax1 = salary * 12 / 100;
                    relieve = 4605;
                    afterRelieve = tax1 - relieve;
                    Console.WriteLine("Your tax is = {0}\t ", afterRelieve);
                    Console.WriteLine("Your relieve is = {0}\t ", relieve);

                    takehome = salary - afterRelieve;
                    Console.WriteLine("Your Take Home is = {0}\t ", takehome);





                }

                else if (salary < 500000)
                {

                    tax1 = salary * 18 / 100;
                    Console.WriteLine("Your tax is = {0}\t ", tax1);

                    relieve = tax1 - 7230;
                    Console.WriteLine("Your relieve is = {0}\t ", relieve);

                    takehome = salary - relieve;
                    Console.WriteLine("Your Take Home is = {0}\t ", takehome);


                }

                else if (salary >= 500000)
                {
                    tax1 = salary * 25 / 100;
                    Console.WriteLine("Your tax is = {0}\t ", tax1);

                    relieve = tax1 - 10050;
                    Console.WriteLine("Your relieve is = {0}\t ", relieve);

                    takehome = salary - relieve;
                    Console.WriteLine("Your Take Home is = {0}\t ", takehome);

                }

                else

                    return;










            }

                Console.ReadKey();
        }


    }
}
