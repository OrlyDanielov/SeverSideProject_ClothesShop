﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary;

namespace WebApplication.Controllers
{
    public class PurchaseController : ApiController
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
        /*public void Post([FromBody]string value)
        {
        }*/
        //public void Post(Purchase p)
        //{
        //    ClothesShopDBConnection db = new ClothesShopDBConnection();
        //    db.Purchases.Add(p);
        //    db.SaveChanges();
        //}

        [Route("api/Purchase")]
        public HttpResponseMessage Post([FromBody]List<Purchase> purchaces)
        {
            var isSaved = DBQuery.UpdateProductInv_AND_addedPurchase(purchaces);
            return isSaved ? Request.CreateResponse(HttpStatusCode.OK, isSaved) : Request.CreateResponse(HttpStatusCode.BadRequest, "");
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