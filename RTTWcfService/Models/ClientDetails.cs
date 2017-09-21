using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RTTWcfService.Models
{
    [DataContract]  
    public class ClientDetails
    {
        int clientId /*= int.MaxValue*/;
        string name = string.Empty;
        string gender = string.Empty;
        string cellNumber = string.Empty;
        string workTel = string.Empty;

        [DataMember]
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DataMember]
        public string CellNumber
        {
            get { return cellNumber; }
            set { cellNumber = value; }
        }

        [DataMember]
        public string WorkTel
        {
            get { return workTel; }
            set {  workTel = value; }
        }
    }
}