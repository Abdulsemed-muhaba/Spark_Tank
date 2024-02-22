using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using SparkTank.Application.DTOs.InvestorDto;

namespace SparkTank.Application.Features.Investor.Request.Queries
{
    public class GetInvestorsRequest: IRequest<GetInvestorsDto>
    {
    }
}