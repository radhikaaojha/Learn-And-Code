using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemStmt1.Common;
using ProblemStmt1.Models;

namespace ProblemStmt1.Helper
{
    public static class CarbonFootprintCalculator
    {
        public static CarbonFootprintResponse GetCarbonFootprint(EmailInfoRequest emailInfo)
        {
            CarbonFootprintResponse carbonFootprint = new CarbonFootprintResponse
            {
                TotalCarbonEmissionFromInbox = emailInfo.NoOfRecievedEmails * CarbonFootprintConstants.InboxEmailCO2EmissionPerG / 1000.0,
                TotalCarbonEmissionFromSpam = emailInfo.NoOfRecievedEmails * CarbonFootprintConstants.SpamEmailCO2EmissionPerG / 1000.0,
                TotalCarbonEmissionFromSent = emailInfo.NoOfRecievedEmails * CarbonFootprintConstants.SentEmailCO2EmissionPerG / 1000.0
            };

            return carbonFootprint;
        }
    }
}
