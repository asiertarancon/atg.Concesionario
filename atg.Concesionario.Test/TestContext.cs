using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Data.Common;
using atg.Concesionario.Domain.Customers;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using atg.Concesionario.Domain.Vehicles;
using atg.Concesionario.Domain.Budgets;
using System.Linq;

namespace atg.Concesionario.Test
{
    public class TestContext : DbContext
    {
        public TestContext()
            : base("Name=ConcesionarioAsier")
        {

        }
        public TestContext(bool enableLazyLoading, bool enableProxyCreation)
            : base("Name=ConcesionarioAsier")
        {
            Configuration.ProxyCreationEnabled = enableProxyCreation;
            Configuration.LazyLoadingEnabled = enableLazyLoading;
        }
        public TestContext(DbConnection connection)
            : base(connection, true)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Budget> Budgets { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Suppress code first model migration check          
            Database.SetInitializer<TestContext>(new AlwaysCreateInitializer());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public void Seed(TestContext Context)
        {
            var customers = new List<Customer>()
            {
                new Customer() {Id=1, Name= "Asier", Surnames="Tarancón García", Telephone="515151223", Vip = true },
                new Customer() {Id=1, Name= "Pepe", Surnames="Gotera", Telephone="1231233", Vip = false }
            };

            var vehicles = new List<Vehicle>()
            {
                new Vehicle() {Id=1, Brand="Seat", Model="Ibiza", Horsepower=90 }
            };

            var budgets = new List<Budget>()
            {
                new Budget() {Id=1, Vehicle = vehicles.First(), Customer = customers.First(), Amount=12000, State = "" }
            };

            Context.Customers.AddRange(customers);
            Context.Vehicles.AddRange(vehicles);
            Context.Budgets.AddRange(budgets);

            Context.SaveChanges();
        }

        public class DropCreateIfChangeInitializer : DropCreateDatabaseIfModelChanges<TestContext>
        {
            protected override void Seed(TestContext context)
            {
                context.Seed(context);
                base.Seed(context);
            }
        }

        public class CreateInitializer : CreateDatabaseIfNotExists<TestContext>
        {
            protected override void Seed(TestContext context)
            {
                context.Seed(context);
                base.Seed(context);
            }
        }

        public class AlwaysCreateInitializer : DropCreateDatabaseAlways<TestContext>
        {
            protected override void Seed(TestContext context)
            {
                context.Seed(context);
                base.Seed(context);
            }
        }


    }
}
