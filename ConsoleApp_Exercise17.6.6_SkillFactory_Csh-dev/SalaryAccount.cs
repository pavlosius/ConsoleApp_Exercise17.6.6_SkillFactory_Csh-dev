using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exercise17._6._6_SkillFactory_Csh_dev
{
    internal class SalaryAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }
        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }
}
