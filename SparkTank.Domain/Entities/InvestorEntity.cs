using SparkTank.Domain.Entities.Common;

namespace SparkTank.Domain.Entities;
public class InvestorEntity : BaseEntity
{
    string Full_Name { get; set; }
    string Email { get; set; }
    string Password { get; set; }
    string Company_Name { get; set; }
    string Industry { get; set; }
    string Location { get; set; }
}
