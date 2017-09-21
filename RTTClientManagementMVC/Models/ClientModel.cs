using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RTTClientManagementMVC.Models
{
    public class ClientModel
    {
        public int clientId { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string cellNumber { get; set; }
        public string workTel { get; set; }
    }
}