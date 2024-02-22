using MediatR;
using SparkTank.Application.DTOs.StartupDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SparkTank.Application.Features.Startups.Request.Commands
{
    public class CreateStartupCommand : IRequest<CreateStartupDto>
    {
        public CreateStartupDto? createStartupDto { get; set; }
    }
}
