using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkTank.Application.DTOs.InvestorDto
{
    public class GetInvestorsDto
    {
        string Full_Name { get; set; }
        string Email { get; set; }
        string Company_Name { get; set; }
        string Industry { get; set; }
        string Location { get; set; }
    }
}