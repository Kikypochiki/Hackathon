using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    public class donation
    {
        public int donationID { get; set; }
        public string donatorName { get; set; }
        public string contactInfo { get; set; }
        public string donationHubLocation { get; set; }
        public string donationType { get; set; }

        public string transactionID { get;set; }
    }
}
