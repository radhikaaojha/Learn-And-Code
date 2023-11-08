using ProblemStmt1.Helper;
using ProblemStmt1.Models;

namespace ProblemStmt1
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmailInfoRequest emailInfo = new EmailInfoRequest
            {
                Email = "radhikaaojha@gmail.com",
                NoOfSpamEmails = 5,
                NoOfRecievedEmails = 5,
                NoOfSentEmails = 5
            };

            CarbonFootprintResponse carbonFootprint = CarbonFootprintCalculator.GetCarbonFootprint(emailInfo);
            carbonFootprint.Email = emailInfo.Email;
            carbonFootprint.Source =CarbonFootprintForEmail.GetSource(carbonFootprint.Email);

            CarbonFootprintForEmail.DisplayCarbonFootprint(carbonFootprint);
        }
    }
}