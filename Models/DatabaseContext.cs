using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Documents;
using Settings = AlDar_1._0.Properties.Settings;

namespace AlDar_1._0.Models
{
    internal class DatabaseContext :DbContext
    {
        public DatabaseContext() : base()
        {
            Database.Connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "+Settings.Default.DbPath+Settings.Default.DbName+ ";Integrated Security = True";
            Database.SetInitializer<DatabaseContext>(new CreateDatabaseIfNotExists<DatabaseContext>());
        }
        public DbSet<BaseProducts> Products { get; set; }
        public DbSet<EditProducts> EditProducts { get; set; }
        public DbSet<Valuations> Valuations { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
