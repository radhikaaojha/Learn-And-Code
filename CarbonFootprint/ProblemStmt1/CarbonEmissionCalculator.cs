using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStmt1
{
    public static class CarbonEmissionCalculator
    {
        public static CarbonFootprintResponseModel getCarbonFootprint(EmailInfoRequestModel emailInfo)
        {
            CarbonFootprintResponseModel carbonFootprint = new CarbonFootprintResponseModel
            {
                TotalCarbonEmissionFromInbox = emailInfo.NoOfRecievedEmails * CarbonFootprintForEmail.InboxEmailCO2EmissionPerG / 1000.0,
                TotalCarbonEmissionFromSpam = emailInfo.NoOfRecievedEmails * CarbonFootprintForEmail.SpamEmailCO2EmissionPerG / 1000.0,
                TotalCarbonEmissionFromSent = emailInfo.NoOfRecievedEmails * CarbonFootprintForEmail.SentEmailCO2EmissionPerG / 1000.0
            };

            return carbonFootprint;
        }
    }
}
