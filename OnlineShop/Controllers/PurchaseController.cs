﻿using OnlineShop.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace OnlineShop.Controllers
{
    public class PurchaseController : ApiController
    {
        private readonly IProductService _productService;

        public PurchaseController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Purchase
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Purchase/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Purchase
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Purchase/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Purchase/5
        public void Delete(int id)
        {
        }
    }
}