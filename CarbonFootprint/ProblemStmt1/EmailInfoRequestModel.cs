using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStmt1
{
    public class EmailInfoRequestModel
    {
        public string Email { get; set; }
        public int NoOfSpamEmails { get; set; }
        public int NoOfSentEmails { get; set; }
        public int NoOfRecievedEmails { get; set; }
    }
}
