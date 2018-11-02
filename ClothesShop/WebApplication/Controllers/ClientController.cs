using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.DTO;
using ClassLibrary;

namespace WebApplication.Controllers
{
    public class ClientController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        /* // PUT api/<controller>/5
         public void Put(int id, [FromBody]string value)
         {
         }*/
        [Route("api/Student/{_id}")]
        public dynamic Put(int _id, [FromBody]string _password)
        {
            Console.WriteLine(" HELLO !!!!!");

            ClothesShopDBConnection db = new ClothesShopDBConnection();
            Client c = db.Clients.SingleOrDefault(x => x.id == _id);
            Console.WriteLine("before if");
            if (c != null && c.password == _password)
            {
                Console.WriteLine("in the if");
                ClientDTO logClient =  new ClientDTO()
                {
                    id = c.id,
                    name = c.name,
                    password = c.password
                };
                return logClient;
            }
            else
            {
                return null;
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}