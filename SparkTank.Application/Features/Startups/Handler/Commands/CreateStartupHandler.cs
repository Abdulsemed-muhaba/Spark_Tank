using MediatR;
using SparkTank.Application.DTOs.StartupDto;
using SparkTank.Application.Features.Startups.Request.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkTank.Application.Features.Startups.Handler.Commands
{
    public class CreateStartupHandler : IRequestHandler<CreateStartupCommand, CreateStartupDto>
    {
        public CreateStartupHandler()
        {
        }

        public Task<CreateStartupDto> Handle(CreateStartupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
