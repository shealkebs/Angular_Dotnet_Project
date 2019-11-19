using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClientDetailsWebApi.DAL
{
    public class ClientAddress
    {
        [Key]
        public int AddressId { get; set; }

        public string ClientLocation { get; set; }

        public string City { get; set; }

        //  [Display(Name = "ClientID")]
        public virtual int ClientID { get; set; }
        [ForeignKey ("ClientID") ]
        public virtual ClientInformation ClientInformations { get; set; }
    }
}