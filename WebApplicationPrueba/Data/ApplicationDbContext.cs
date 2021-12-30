using AplicacionPrueba.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationPrueba.Models;

namespace WebApplicationPrueba.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Zapato> Zapatos { get; set; }

        public DbSet<WebApplicationPrueba.Models.Cliente> Cliente { get; set; }
    }
}
