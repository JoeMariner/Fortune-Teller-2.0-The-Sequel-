using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_2___The_sequel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fortune Teller 2: The Sequel! \nPress \"Enter\" to come in and we'll get started!");
            Console.ReadLine();
            

            Console.WriteLine("\aEnter your first name");
            string firstname = Console.ReadLine();

            if (firstname == "quit")
                
                {
                
                Quit();

                }

            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();
            
            if (lastname == "quit")                
            {
                Quit();
                
            }

            Console.WriteLine(Greeting(firstname, lastname));


            Console.WriteLine("\n\nHow old are you?");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
           
            if (ageStr == "quit")
            {
                Quit();
               
            }


            Console.WriteLine("Which month were you born? input a number. (June = 06)");
            string monthStr = Console.ReadLine();
            int month = int.Parse(monthStr);

            if (monthStr == "quit")
            {
                Quit();
                
            }
             

            Console.WriteLine("How many siblings do you have?");
            string numOfSiblingsStr = Console.ReadLine();
            int numOfSiblings = int.Parse(numOfSiblingsStr);

            if (numOfSiblingsStr == "quit")
            {
                Quit();
               
            }

            Console.WriteLine("What is your favorite ROYGBIV color?\n\n If you don't know the colors, I can cast a magic spell and show you a rainbow. \n Enter \"HELP\" to see");

            string favoriteColor = Console.ReadLine();

            favoriteColor = favoriteColor.ToLower();
            if (favoriteColor == "help")
            {
                Console.WriteLine("Here ya go: red, orange, yellow, green, blue, indigo, and violet");
                favoriteColor = Console.ReadLine();
                favoriteColor = favoriteColor.ToLower();
            }
            else if (favoriteColor == "quit")

            {
                Quit();
            }

            Console.WriteLine("\nOk! Looks like we're all set! Now...I'm gonna say some magic words. \nPress enter after I say them! \n\nFORTUNE-O SPEGHETTI-O REVEAL-O!!");
            Console.ReadLine();

            Console.WriteLine("\n" + firstname + " " + lastname + " " + "will retire in" + " " + (NumOfYearsToRetire(age)) + " " + "years" + " " + "with $" + (BankAccount(month)) + " " + "in the bank," + "\na vacation home in " + (VacationHome(numOfSiblings)) + " " + "and a stylish " +(Transportation(favoriteColor)) + " " + "to ride in!");



        }
        static string Greeting(string firstname, string lastname)
        {

            string GreetingMessage = "Greetings" + " " + firstname + " " + lastname + "!!\nI will tell you your fortune!";

            return GreetingMessage;
        } 
        static int NumOfYearsToRetire(int age)
        {
            int yearsToRetire = age % 2;

            if (yearsToRetire == 1)
            {
                yearsToRetire = 24;
                return yearsToRetire;
            }
            else
                yearsToRetire = 11;
                return yearsToRetire;
        } 
        static double BankAccount(double month)
        {


            if (month <= 12 && month >= 9)
            {

                double MoneyInBankAccount = 99999;
                return MoneyInBankAccount;

            }
            else if (month <= 8 && month >= 5)
            {
                double MoneyInBankAccount = 1000001;
                return MoneyInBankAccount;
            }
            else if (month <= 4 && month >= 1)
            {
                double MoneyInBankAccount = 444444;
                return MoneyInBankAccount;

            }

            else
            {
                double MoneyInBankAccount = 0.00;
                return MoneyInBankAccount;
            }

            



        } 
        static string VacationHome(int numOfSiblings) 
        {
            if (numOfSiblings < 1)
            {
                string location = "New New York";
                return location;
            }
            else if (numOfSiblings == 1)
            {
                string location = "Diagon Alley";
                return location;
            }
            else if (numOfSiblings == 2)
            {
                string location = "Hyrule";
                return location;
            }
            else if (numOfSiblings == 3)
            {
                string location = "The Shire";
                return location;
            }
            else if  (numOfSiblings > 3)
            { 
                string location = "Mushroom Kingdom";
                return location;
            }
            else
            {
                string location = "Mount Doom";
                return location;
            }
            
        }
        static string Transportation(string favoriteColor)
        {
            switch (favoriteColor)
            {
                case "red":
                    favoriteColor = "Batmobile";
                    return favoriteColor;
                    

                case "orange":
                    favoriteColor = "Millenium Falcon";
                    return favoriteColor;
                    

                case "yellow":
                    favoriteColor = "Planet Express Ship";
                    return favoriteColor;
                    

                case "green":
                    favoriteColor = "hover board";
                    return favoriteColor;
                    

                case "blue":
                    favoriteColor = "giant hamster ball automobile";
                    return favoriteColor;
                    

                case "indigo":
                    favoriteColor = "portal gun";
                    return favoriteColor;
                    

                case "violet":
                    favoriteColor = "Planet Express ship";
                    return favoriteColor;
                    

                default:
                    favoriteColor = "Cardboard box";
                    return favoriteColor;
                    

                    
                     
            }
        } 
        static void Quit()
        {
            Console.WriteLine("You're quitting? *pfft* Fine. Go.");
            Console.ReadKey();
            Environment.Exit(0);
        }
       
       
    }
}
