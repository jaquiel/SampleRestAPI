using SampleRestAPI.Data.Mapping;
using SampleRestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleRestAPI.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Sekeleton");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PersonMapping());
        }

    }
}
