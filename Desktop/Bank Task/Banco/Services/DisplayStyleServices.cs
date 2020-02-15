using Banco.Interfaces;
using System;
using System.Collections.Generic;

namespace Banco
{
    class DisplayStyleServices : IDisplayStyleServices
    {
        public void ApplicationRibbon()
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(string.Format("{0}\n{1}\n{2}\n{0}", CenteredString("", Console.WindowWidth, '-'), CenteredString("BANCO", Console.WindowWidth, ' '), CenteredString("(Console based banking application)", Console.WindowWidth, ' ')));
        }

        public void ClearScreen()
        {
            Console.Clear();
            ApplicationRibbon();
        }

        public void DisplayOptions(string optionType)
        {
            List<string> pageOptions = new List<string>();
            Console.WriteLine(CenteredString(optionType, Console.WindowWidth, ' '));
            if (optionType.Equals("Banco Home"))
            {
                List<string> bancoHomeOptions = new List<string>()
                {
                    "Application Admin","Bank Admin","Bank Teller","Account Holder","Exit"
                };
                Console.WriteLine( CenteredString("select the user role for login", Console.WindowWidth, ' '));
                pageOptions = bancoHomeOptions;
            }
            else if (optionType.Equals("Application Admin Home"))
            {
                List<string> applicationAdminOptions = new List<string>()
                {
                    "Register Bank Admin","Deactivate Bank","Log out"
                };
                pageOptions = applicationAdminOptions;
            }
            else if (optionType.Equals("Bank Admin Home"))
            {
                List<string> bankAdminOptions = new List<string>()
                {
                    "Register Bank Teller","Bank Config","Revert Transaction","Log out"
                };
                pageOptions = bankAdminOptions;
            }
            else if (optionType.Equals("Bank Teller Home"))
            {
                List<string> bankTellerOptions = new List<string>()
                {
                    "Create account","Deactivate account","View Transaction History","Revert Transaction","Log out"
                };
                pageOptions = bankTellerOptions;
            }
            else if (optionType.Equals("Account Holder Home"))
            {
                List<string> accountHolderOptions = new List<string>()
                {
                    "Cash Deposit","Cash Withdrawal","Transfer Funds","Transaction History","Log out"
                };
                pageOptions = accountHolderOptions;
            }
            for (int i = 0; i < pageOptions.Count; i++)
            {

                Console.WriteLine(LeftFormattedString(new String($"{i + 1}.  " + pageOptions[i]), Console.WindowWidth - 20, ' '));
            }
            //Console.SetCursorPosition(0, 18);
        }

        public string CenteredString(string s, int width, char symbol)
        {
            if (s.Length >= width)
            {
                return s;
            }

            int leftPadding = (width - s.Length) / 2;
            int rightPadding = width - s.Length - leftPadding;

            return new string(symbol, leftPadding) + s + new string(symbol, rightPadding);
        }
        public string LeftFormattedString(string s, int width, char symbol)
        {
            if (s.Length >= width)
            {
                return s;
            }
            return new string(symbol, (width) / 2) + s;
        }

        public dynamic LoginPage(string role)
        {
            Console.WriteLine(string.Format("{0}\n{1}\n", CenteredString("", Console.WindowWidth, '-'), CenteredString($"{role} login", Console.WindowWidth, ' ')));
            Console.Write(LeftFormattedString("Email:", Console.WindowWidth - 30, ' '));
            string Email = Console.ReadLine();
            Console.Write(LeftFormattedString("Password:", Console.WindowWidth - 30, ' '));
            string Password = Console.ReadLine();
            Console.Write( LeftFormattedString("Secret Key:", Console.WindowWidth - 30, ' '));
            string SecretKey = Console.ReadLine();
            return new List<string>() { Email, Password, SecretKey };
        }
        public void ErrorMessage(string message)
        {
            Console.WriteLine(string.Format("{0}\n{1}\n{0}", CenteredString("", Console.WindowWidth, '*'), CenteredString("Selected valid Option", Console.WindowWidth, ' ')));
        }
    }
}
