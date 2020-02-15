using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IDisplayStyleServices
    {
        public string CenteredString(string s, int width, char symbol);
        public void ClearScreen();
        public void ApplicationRibbon();
        public void DisplayOptions(string optionType);
        public string LeftFormattedString(string s, int width, char symbol);
        public dynamic LoginPage(string role);
    }
}
