using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace GBCSporting2021_CtrlStacks.Models
{
    public class SportsProContext : DbContext
    {
        public SportsProContext()
        {
        }

        public SportsProContext(DbContextOptions<SportsProContext> options) : base(options)
        {}

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Technician> Technicians { get; set; }


        //SQL LITE
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "SportsPro.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);
            optionsBuilder.UseSqlite(connection);
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var jData = System.IO.File.ReadAllText("./wwwroot/assets/country.json");
            List<Country> data = JsonConvert.DeserializeObject<List<Country>>(jData);
            int cntId = 1;
            List<Country> countries = new List<Country>();
            foreach (var c in data)
            {
                countries.Add(new Country
                {
                    CountryId = cntId,
                    Code = c.Code,
                    Name = c.Name
                });
                cntId += 1;
            }
            modelBuilder.Entity<Country>().HasData(countries);
            var cultureInfo = new CultureInfo("en-US");
            string[] formats = { "MM/dd/yyyy" };
            List<Product> products = new List<Product> {
                new Product
                {
                    ProductId = 1, Code = "TRNY10", Name ="Tournament Master 1.0", YearlyPrice = 4.99, ReleaseDate = DateTime.ParseExact("12/01/2015", formats, cultureInfo)
                },
                new Product
                {
                    ProductId = 2, Code = "LEAG10", Name ="League Scheduler 1.0", YearlyPrice = 4.99, ReleaseDate = DateTime.ParseExact("05/01/2016", formats, cultureInfo)
                },
                new Product
                {
                    ProductId = 3, Code = "LEAGD10", Name ="League Scheduler Deluxe 1.0", YearlyPrice = 7.99, ReleaseDate = DateTime.ParseExact("08/01/2016", formats, cultureInfo)
                },
                new Product
                {
                    ProductId = 4, Code = "DRAFT10", Name ="Draft Manager 1.0", YearlyPrice = 4.99, ReleaseDate = DateTime.ParseExact("02/01/2017", formats, cultureInfo)
                },
                new Product
                {
                    ProductId = 5, Code = "TEAM10", Name ="Team Manager 1.0", YearlyPrice = 4.99, ReleaseDate = DateTime.ParseExact("05/01/2017", formats, cultureInfo)
                },
                new Product
                {
                    ProductId = 6, Code = "TRNY20", Name ="Tournament Master 2.0", YearlyPrice = 5.99, ReleaseDate = DateTime.ParseExact("02/15/2018", formats, cultureInfo)
                },
                new Product
                {
                    ProductId = 7, Code = "DRAFT20", Name ="Draft Manager 2.0", YearlyPrice = 5.99, ReleaseDate = DateTime.ParseExact("07/15/2019", formats, cultureInfo)
                }
            };
            List<Technician> technicians = new List<Technician>
            {
                new Technician{ TechnicianId = 1, Name="Alison Diaz", Email="alison@sportsprosoftware.com", Phone="800-55-0443"},
                new Technician{ TechnicianId = 2, Name="Andew Wilson", Email="awilson@sportsprosoftware.com", Phone="800-55-0449"},
                new Technician{ TechnicianId = 3, Name="Gina Fiori", Email="gfiori@sportsprosoftware.com", Phone="800-55-0459"},
                new Technician{ TechnicianId = 4, Name="Gunter Wendt", Email="gunter@sportsprosoftware.com", Phone="800-55-0400"},
                new Technician{ TechnicianId = 5, Name="Jason Lee", Email="jsaon@sportsprosoftware.com", Phone="800-55-0444"},
            };
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Technician>().HasData(technicians);
        }
    }
}
