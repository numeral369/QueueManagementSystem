using Senhas_teste.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Senhas_teste.DAL
{
    public class SenhaContext : DbContext
    {
        public SenhaContext() : base("SenhaContext")
        {
        }

        public DbSet<SenhaModel> Senhas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}