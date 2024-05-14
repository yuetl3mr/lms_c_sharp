using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryapp
{
    internal class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginForm());
            Application.Run(new LoginForm());
        }
    }
}
