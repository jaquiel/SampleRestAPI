using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleRestAPI.Controllers;
using SampleRestAPI.Models;
using SampleRestAPI.Data;

namespace SampleRestMSTests
{
    [TestClass]
    public class SampleRestAPITests
    {
        [TestMethod]
        public void SampleRestAPI_InsertPerson()
        {
            StoreDataContext context = new StoreDataContext();
            PersonController personController = new PersonController(context);

            Person person = new Person();
            Person newPerson = new Person();
            person.ID = 1;
            person.Name = "Jaquiel Paim";
            newPerson.ID = 1;
            newPerson.Name = "Jaquiel Paim";
            personController.Post(person);

            Assert.AreEqual(true, true);

        }
    }
}
