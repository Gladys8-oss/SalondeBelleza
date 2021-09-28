using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza.BL
{
  public class Contexto : DbContext
    {
        public Contexto(): base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\SalondeBellezaDB.mdf")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           // Database.SetInitializer(new DatosdeInicio());
        }
        public DbSet<Producto>  Productos { get; set; }
    }
}
