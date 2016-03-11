using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JoeysPetStore.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateRecieved { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }  
     
    }
    public class PetDBContext : DbContext
    {
        public PetDBContext(): base("SQLAzureConnection")
        {
            Database.SetInitializer<PetDBContext>(new DropCreateDatabaseIfModelChanges<PetDBContext>());
        }
        public DbSet<Pet> Pets { get; set; }
    }
}