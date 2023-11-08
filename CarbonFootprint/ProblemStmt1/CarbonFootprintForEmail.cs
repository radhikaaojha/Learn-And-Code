using ProblemStmt1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStmt1
{
    public static class CarbonFootprintForEmail
    {
        public static string GetSource(string email)
        {
            int atIndex = email.IndexOf("@");
            int dotComIndex = email.IndexOf(".com");

            if (atIndex >= 0 && dotComIndex > atIndex)
            {
                string source = email.Substring(atIndex + 1, dotComIndex - atIndex - 1);
                return source;
            }

            return "Invalid email format";
        }

        public static void DisplayCarbonFootprint(CarbonFootprintResponse carbonFootprint)
        {
            Console.WriteLine("Email: " + carbonFootprint.Email);
            Console.WriteLine("Source: " + carbonFootprint.Source);
            Console.WriteLine("Inbox: " + carbonFootprint.TotalCarbonEmissionFromInbox + " KG");
            Console.WriteLine("Sent: " + carbonFootprint.TotalCarbonEmissionFromSent + " KG");
            Console.WriteLine("Spam: " + carbonFootprint.TotalCarbonEmissionFromSpam + " KG");
        }
    }
}
