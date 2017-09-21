using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RTTClientManagementMVC.ViewModels
{
    public class ClientViewModel
    {
        //Address
        public int addressId;
        public string resAddress = string.Empty;
        public string workAddress = string.Empty;
        public string posAddress = string.Empty;
        public int clientId;

        //Client Data
        public string name = string.Empty;
        public string gender = string.Empty;
        public string cellNumber = string.Empty;
        public string workTel = string.Empty;


    }
}