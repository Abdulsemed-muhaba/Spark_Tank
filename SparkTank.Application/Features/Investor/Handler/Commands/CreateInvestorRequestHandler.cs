using MediatR;
using AutoMapper;
using SparkTank.Application.Features.Investor.Request.Commands;
using SparkTank.Application.Responses;

namespace SparkTank.Application.Features.Investor.Handler.Commands
{
    public class CreateInvestorRequestHandler: IRequestHandler<CreateInvestorRequest, BaseResponseClass>
    {
        private readonly IMapper _mapper;

        public CreateInvestorRequestHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        

        public async Task<BaseResponseClass> Handle(CreateInvestorRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}