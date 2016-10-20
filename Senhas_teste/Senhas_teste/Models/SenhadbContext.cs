//using System;
//using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
//using System.Linq;
//using System.Web;

namespace Senhas_teste.Models
{
    public class SenhadbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SenhadbContext() : base("name=SenhadbContext")
        {
        }

        //public System.Data.Entity.DbSet<Senhas_teste.Models.SenhaModel> Senhas { get; set; }
        public DbSet<SenhaModel> Senhas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
