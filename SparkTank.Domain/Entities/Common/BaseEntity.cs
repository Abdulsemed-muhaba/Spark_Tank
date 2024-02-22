using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkTank.Domain.Entities.Common;
public class BaseEntity
{
    Guid Id { get; set; }
    DateTime CreatedAt { get; set; }
}
