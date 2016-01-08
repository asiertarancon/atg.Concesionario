using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using atg.Concesionario.Persistence.Repositories;
using System.Linq;
using atg.Concesionario.Domain.Customers;

namespace atg.Concesionario.Test.Repositories
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        DbConnection connection;
        TestContext databaseContext;
        CustomerRepository objRepo;

        [TestInitialize]
        public void Initialize()
        {
            connection = Effort.DbConnectionFactory.CreateTransient();
            databaseContext = new TestContext(connection);
            objRepo = new CustomerRepository(databaseContext);

        }

        [TestMethod]
        public void Customer_Repository_Get_ALL()
        {
            //Act
            var result = objRepo.GetAll().ToList();

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Asier", result[0].Name);
            Assert.AreEqual("Pepe", result[1].Name);            
        }

        [TestMethod]
        public void Customer_Repository_Create()
        {
            //Arrange
            Customer c = new Customer() { Name = "Otro" };

            //Act
            var result = objRepo.Add(c);
            databaseContext.SaveChanges();

            var lst = objRepo.GetAll().ToList();

            //Assert

            Assert.AreEqual(3, lst.Count);
            Assert.AreEqual("Otro", lst.Last().Name);
        }
    }
}
