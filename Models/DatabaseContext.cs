using System.Data.Entity;
using Settings = AlDar_1._0.Properties.Settings;

namespace AlDar_1._0.Models
{
    internal class DatabaseContext :DbContext
    {
        public DatabaseContext() : base()
        {
            Database.Connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "+Settings.Default.DbPath+Settings.Default.DbName+ ";Integrated Security = True";
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Valuations> Valuations { get; set; }
    }
}
