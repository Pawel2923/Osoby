using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using Osoby.Models;

namespace Osoby.DAL
{
    public class OsobaContext : DbContext
    {
        public OsobaContext() : base("OsobyConnectionString")
        {
        }

        public DbSet<Osoba> Osoby { get; set; }
    }
}
