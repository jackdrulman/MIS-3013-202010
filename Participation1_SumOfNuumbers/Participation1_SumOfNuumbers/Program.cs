// collaborated with class

using System;

namespace Participation1_SumOfNuumbers
{
    class Program
    {

        const string CLASS_NAME = "MIS 3013";
        static void Main(string[] args)
        {
           // this won't work bc it is a constant CLASS_NAME = "MIS 3353";

            string firstname = "jack";
            string lastname = "drulman";

            Console.WriteLine("please enter your first name >>");
            firstname = Console.ReadLine(); //getting what the user typed and stored in the

            Console.WriteLine("please enter your last name >>");
            lastname = Console.ReadLine();

            Console.WriteLine("what is your GPA? >>");
            string gpaInput = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaInput);

            
            Console.WriteLine(firstname + " " + lastname + " is apart of " + CLASS_NAME + " with a GPA of " +
                gpa.ToString("n2"));



        }
    }
}
