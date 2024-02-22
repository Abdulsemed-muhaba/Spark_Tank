using MediatR;
using AutoMapper;
using SparkTank.Application.DTOs.InvestorDto;
using SparkTank.Application.Features.Investor.Request.Queries;

namespace SparkTank.Application.Features.Investor.Handler.Queries
{
    public class GetInvestorsRequestHandler: IRequestHandler<GetInvestorsRequest, GetInvestorsDto>
    {
        private readonly IMapper _mapper;
        
        public GetInvestorsRequestHandler(IMapper mapper)
        {
            _mapper = mapper;
            
        }
        
        public async Task<GetInvestorsDto> Handle(GetInvestorsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }       
    }
}