using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MJBScom.Controllers;

namespace MJBScom.Controllers.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      
      [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            //Act
            ActionResult result = new HomeController().Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}