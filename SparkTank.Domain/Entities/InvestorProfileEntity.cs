using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkTank.Domain.Entities
{
    public class InvestorProfileEntity
    {
        public string Company_Name { get; set; }
        public List<string> Investment_Preferences { get; set; }
        public string Funding_Plan { get; set; }
    }
}