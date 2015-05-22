namespace SuperHeroesWebSite.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SuperHeroesDataContext : DbContext
    {
        // Your context has been configured to use a 'SuperHeroesDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SuperHeroesWebSite.Models.SuperHeroesDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SuperHeroesDataContext' 
        // connection string in the application configuration file.
        public SuperHeroesDataContext()
            : base("name=SuperHeroesDataContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<SuperHero> SuperHeroes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}