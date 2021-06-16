using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleViewer.Controllers;
using PersonReader.Interface;
using System.Collections.Generic;
using System.Linq;

namespace PeopleViewer.Test
{
    [TestClass]
    public class PeopleControllerTests
    {
        [TestMethod]
        public void PeopleController_OnRuntimeReaderAction_ModelIsPopulated()
        {
            // Arrange
            IPersonReader reader = new FakeReader();
            var controller = new PeopleController(reader);

            // Act
            var result = controller.UseRuntimeReader() as ViewResult;
            Assert.IsNotNull(result, "Controller action failed");
            var model = result!.Model as IEnumerable<Person>;

            // Assert
            Assert.IsNotNull(model, "Model property is not populated");
            Assert.AreEqual(2, model!.Count());
        }

        [TestMethod]
        public void PeopleController_OnRuntimeReaderAction_ReaderTypeIsPopulated()
        {
            // Arrange
            IPersonReader reader = new FakeReader();
            var controller = new PeopleController(reader);
            var expectedType = "PeopleViewer.Test.FakeReader";

            // Act
            var result = controller.UseRuntimeReader() as ViewResult;
            Assert.IsNotNull(result, "Controller action failed");
            var actualType = result!.ViewData["ReaderType"];

            // Assert
            Assert.IsNotNull(actualType, "ReaderType is not populated");
            Assert.AreEqual(expectedType, actualType);
        }
    }
}
