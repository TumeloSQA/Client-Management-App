using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RTTWcfService.Models
{
    public class AddressDetails
    {
        int addressId /*= int.MaxValue*/;
        string resAddress = string.Empty;
        string workAddress = string.Empty;
        string posAddress = string.Empty;
        int clientId /*= int.MaxValue*/;

        [DataMember]
        public int AddressId
        {
            get { return addressId; }
            set { addressId = value; }
        }

        [DataMember]
        public string ResAddress
        {
            get { return resAddress; }
            set { resAddress = value; }
        }

        [DataMember]
        public string WorkAddress
        {
            get { return workAddress; }
            set { workAddress = value; }
        }

        [DataMember]
        public string PosAddress
        {
            get { return posAddress; }
            set { posAddress = value; }
        }

        [DataMember]
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
    }
}