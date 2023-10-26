using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStmt1
{
    public class CarbonFootprintResponseModel
    {
        public string Email { get; set; }
        public string Source { get; set; }
        public double TotalCarbonEmissionFromInbox { get; set; }
        public double TotalCarbonEmissionFromSent { get; set; }
        public double TotalCarbonEmissionFromSpam { get; set; }
    }
}
