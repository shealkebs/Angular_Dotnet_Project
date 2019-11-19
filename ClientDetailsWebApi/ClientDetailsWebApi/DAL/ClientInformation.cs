using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientDetailsWebApi.DAL
{
    public class ClientInformation
    {
        [Key]
        public int ClientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public List<ClientAddress> clientAddresses { get; set; }
    }
}