using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkTank.Application.Responses;
public class BaseResponseClass
{
    public Guid Id { get; set; }
    public string Message { get; set; }
    public bool Success { get; set; } 
    public List<string> Error { get; set; }
}