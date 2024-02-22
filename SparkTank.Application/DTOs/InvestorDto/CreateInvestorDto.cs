using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkTank.Application.DTOs.InvestorDto
{
    public class CreateInvestorDto
    {
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Industry { get; set; }
        public string Location { get; set; }
    }
}
