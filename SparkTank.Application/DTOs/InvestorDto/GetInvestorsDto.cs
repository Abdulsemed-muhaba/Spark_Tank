using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkTank.Application.DTOs.InvestorDto
{
    public class GetInvestorsDto
    {
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Company_Name { get; set; }
        public string Industry { get; set; }
        public string Location { get; set; }
    }
}