using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exercise17._6._6_SkillFactory_Csh_dev
{
    internal class NormalAccount:IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }
        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance >= 1000)
                Interest -= Balance * 0.4;
        }
    }
}
