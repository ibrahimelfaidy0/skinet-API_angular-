using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoredContext context;

        public ProductsController(StoredContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> get()
        {
            return await context.Products.ToListAsync();
        }


        [HttpGet("{id}")]
       public async Task <ActionResult<Product>> getproduct(int id)
       {
                return await context.Products.FindAsync(id);                
       }

    }
}