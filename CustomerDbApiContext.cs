using CoustomWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoustomWebApi
{
    public class CustomerDbApiContext:DbContext
    {
        public CustomerDbApiContext(DbContextOptions<CustomerDbApiContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
