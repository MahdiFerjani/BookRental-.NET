
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace WebApplication3.Models

{
    public class Livrecontext : DbContext
    {

        public Livrecontext(DbContextOptions<Livrecontext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Livre> Livres { get; set; }




    }
}

