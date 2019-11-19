using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClientDetailsWebApi.DAL
{
    public class ClientInformationDbContext:DbContext
    {

        public ClientInformationDbContext():base("ClientInformationDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

        }
        public DbSet<ClientInformation> clientInformation { get; set; }
        public DbSet<ClientAddress> clientAddresses { get; set; }


    }
}