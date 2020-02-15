using Banco.Services;
using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStyleServices display = new DisplayStyleServices();
            UtilityServices utility = new UtilityServices();
            display.ApplicationRibbon();
            display.DisplayOptions("Banco Home");
            Console.Write(display.LeftFormattedString("selected option: ", Console.WindowWidth - 30, ' '));
            while(true)
            {
                var selectedOptions=Console.ReadLine();
                if (selectedOptions.Equals("1"))
                {
                    if (utility.ValidateUser(display.LoginPage("Application Admin"), "Application Admin"))
                        Console.WriteLine("application admin login successful");
                    //ApplicationAdminHome();
                    else
                        Console.WriteLine("enter valid credentials");
                }
                else if (selectedOptions.Equals("2"))
                {
                    utility.ValidateUser(display.LoginPage("Bank Admin"),"Bank Admin");
                }
                else if (selectedOptions.Equals("3"))
                {
                    utility.ValidateUser(display.LoginPage("Bank Teller"),"Bank Teller");
                }
                else if (selectedOptions.Equals("4"))
                {
                    utility.ValidateUser(display.LoginPage("Account Holder"),"Account Holder");
                }
                else if (selectedOptions.Equals("5"))
                {
                    break;
                }
                else
                {
                    display.ErrorMessage("selected valid option");
                    display.DisplayOptions("Banco Home");
                    Console.Write(display.LeftFormattedString("selected option: ", Console.WindowWidth - 30, ' '));
                }

            }
        }
    }
}
