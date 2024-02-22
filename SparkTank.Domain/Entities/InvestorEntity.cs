using SparkTank.Domain.Entities.Common;

namespace SparkTank.Domain.Entities;
public class InvestorEntity : BaseEntity
{
    public string Full_Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<string> Industry { get; set; }
    public string Location { get; set; }
}