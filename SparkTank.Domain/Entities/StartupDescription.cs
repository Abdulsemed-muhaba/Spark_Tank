using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkTank.Domain.Entities
{
    public class StartupDescription
    {
        public string? ProblemStatement { get; set; }
        public string? SolutionOverview { get; set; }
        public string? TotalAddressableMarket { get; set; }
        public string? ValueProposition { get; set; }
        public string? BusinessModel { get; set; }
        public string? MarketAnalysis { get; set; }
        public string? Competitor { get; set; }
        public string? ExitStrategy { get; set; }
        public List<string>? PreviousInvestors { get; set; }

    }
}
