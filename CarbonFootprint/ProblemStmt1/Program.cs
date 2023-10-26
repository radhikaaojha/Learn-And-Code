namespace ProblemStmt1
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmailInfoRequestModel emailInfo = new EmailInfoRequestModel
            {
                Email = "radhikaaojha@gmail.com",
                NoOfSpamEmails = 5,
                NoOfRecievedEmails = 5,
                NoOfSentEmails = 5
            };

            CarbonFootprintResponseModel carbonFootprint = CarbonEmissionCalculator.getCarbonFootprint(emailInfo);
            carbonFootprint.Email = emailInfo.Email;
            carbonFootprint.Source =CarbonFootprintForEmail.GetSource(carbonFootprint.Email);

            CarbonFootprintForEmail.DisplayCarbonFootprint(carbonFootprint);
        }
    }
}