﻿using SparkTank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkTank.Application.Persistence.Contracts.Auth;

public interface IJwtTokenGenerator
{
    string GenerateToken(InvestorEntity investor);
    string GenerateToken(StartupEntity startup);
}
