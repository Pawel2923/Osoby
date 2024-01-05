using Osoby.Models;
using System.Data.Entity;

namespace Osoby.DAL
{
    public class KontaktyContext : DbContext
    {
        public KontaktyContext() : base("KontaktyConnectionString")
        {

        }

        public DbSet<Kontakt> Kontakty { get; set; }
    }
}
