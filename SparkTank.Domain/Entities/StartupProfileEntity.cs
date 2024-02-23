using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SparkTank.Domain.Entities
{
    public class StartupProfileEntity
    {
        public string? StartupName { get; set; }
        public string? Industry { get; set; }
        public string? Location { get; set; }
        public string? StartupOverview { get; set; }
        public DateTime FoundingDate { get; set; }
        public FundingGoal? StartupFundingGoal { get; set; }
        public StartupDescription? StartupDescription { get; set; }
        public string? Pitchdeck { get; set; }
        public string? PitchVideo { get; set; }
        public string? Vision { get; set; }
        public string? Website { get; set; }
        public string? Achievements { get; set; }
        public StartupContactAddress? contactAddress { get; set; }
        public string? ImageLogo { get; set; }
        public string? ProfileStatus { get; set; }
        public StartupTeamMembers? Teammembers{get; set;}

    }
}
