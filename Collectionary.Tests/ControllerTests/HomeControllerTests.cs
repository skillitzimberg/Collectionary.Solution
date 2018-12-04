using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Collectionary.Controllers;
using Collectionary.Models;

namespace Collectionary.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          //Arrange
        HomeController controller = new HomeController();

        //Act
        ActionResult indexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

  }
}
