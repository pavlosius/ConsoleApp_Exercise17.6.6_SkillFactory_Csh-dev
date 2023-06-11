using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exercise17._6._6_SkillFactory_Csh_dev
{
    internal class Calculator
    {
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
