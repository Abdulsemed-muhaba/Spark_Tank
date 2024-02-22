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
        public string StartupName { get; set; }
        public string Industry { get; set; }
        public string Location { get; set; }
        public string StartupOverview { get; set; }
        public DateTime FoundingDate { get; set; }
        public FundingGoal StartupFundingGoal { get; set; }
        public Description StartupDescription { get; set; }
        public string Pitchdeck { get; set; }
        public string PitchVideo { get; set; }
        public string Vision { get; set; }
        public string Website { get; set; }
        public string Achievements { get; set; }
        public ContactAddress contactAddress { get; set; }
        public string ImageLogo { get; set; }
        public string? ProfileStatus { get; set; }


    }


//Location(required) : string
//Startup Overview(required) : string
//Text(max 250 char)
//Founding Date(required) : Date till here can see others but not added to feed
//Description(required) : entity
//Funding Goals(required) : entity
//Team Members(Key Team Members: Names and roles of founding members and key executives.) (required)
//Pitch deck(required) : string
//Pitch Video(required) : string (url) here the startup is added to the feed
//Vision(optional)
//Text
//Achievements(optional) : string (url)
//Text
//Uploading file like certificates
//Website URL(optional) : string (url)
//Contact Address(optional) : entity
//Image / Logo : string (url)



    }
}
