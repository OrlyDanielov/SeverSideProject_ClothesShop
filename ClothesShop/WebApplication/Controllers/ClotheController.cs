using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary;
using WebApplication.DTO;

namespace WebApplication.Controllers
{
    public class ClotheController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public dynamic Get()
        {
            ClothesShopDBConnection db = new ClothesShopDBConnection();
             return db.Clothes.Where(c => c.is_active == true).Select(x => new ClotheDTO()
            {
                number = x.number,
                details = x.details,
                 priceSupp = x.cosumer_price,
                 priceBuyer = x.cost_price,
                 stock = x.amount_in_stock,
                category = x.category,
                img_url = x.img_url
            }).ToList();

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

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}