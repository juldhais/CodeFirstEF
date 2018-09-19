namespace CodeFirstEF
{
    using CodeFirstEF.Models;
    using System.Data.Entity;

    public class HeroesModel : DbContext
    {
        public HeroesModel()
            : base("name=HeroesModel")
        {
        }

        public virtual DbSet<Hero> Heroes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}