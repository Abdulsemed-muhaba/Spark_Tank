using SparkTank.Application.DTOs.InvestorDto;
using SparkTank.Application.Responses;
using MediatR;

namespace SparkTank.Application.Features.Investor.Request.Commands
{
    public class CreateInvestorRequest: IRequest<BaseResponseClass>
    {
        CreateInvestorDto investorDto { get; set; }
    }
}