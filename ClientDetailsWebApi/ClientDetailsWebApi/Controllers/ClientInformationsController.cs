using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ClientDetailsWebApi.DAL;
using System.Web.Http.Cors;
using System.Web.Routing;

namespace ClientDetailsWebApi.Controllers
{
    public class ClientInformationsController : ApiController
    {

        private ClientInformationDbContext db = new ClientInformationDbContext();
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        // GET: api/ClientInformations?fName=Rushi&lName=Prasad
        //   [Route("FirstName/{fName}/LastName/{lName}")]
        [ResponseType(typeof(ClientInformation))]
        public IHttpActionResult GetClientInformation(String fName, String lName)
        {
            IList<ClientInformation> clients = null;
            if (fName != null && lName == null)
            {
                clients = db.clientInformation.Include(a => a.clientAddresses).Where(t => t.FirstName == fName).ToList();
            }
            else if (fName == null && lName != null)
            {
                clients = db.clientInformation.Include(a => a.clientAddresses).Where(t => t.LastName == lName).ToList();
            }
            else if (fName == null && lName == null)
            {
                clients = db.clientInformation.Include(a => a.clientAddresses).Take(3).ToList();
            }
            else
            {
                clients = db.clientInformation.Include(a => a.clientAddresses).Where(t => t.FirstName == fName && t.LastName == lName).ToList();
            }
            if (clients == null)
            {
                return NotFound();
            }
            return Ok(clients);
        }
    }    
}