﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitIntegrationTestingApps.BLL;
using UnitIntegrationTestingApps.Controllers;
using UnitIntegrationTestingApps.Models;

namespace ProjectName.IntegrationTesting.Controllers
{
    [TestClass()]
    public class StudentControllerTests
    {
        [TestMethod()]
        public void GetStudentTest()
        {
            // Arrange
            //var controller = new StudentController();

            // Act
            var result = Repository.GetStudent();

            // Assert
            //Assert.AreEqual(result, new object());
            //Assert.AreNotSame(result, new Student());
            Assert.AreEqual(result.Department, "CSE");
        }

        [TestMethod]
        public void GetStudentListTest()
        {
            // Arrange
            //var controller = new StudentController();

            // Act
            var result = Repository.GetStudentList();

            //Assert
            Assert.AreNotSame(result.Count, 2);
        }

        [TestMethod]
        public void CreateTest()
        {
            var aStudent = new Student() { FirstName = "Abu", LastName = "Sayed", Department = "CSE,JU" };
            // Arrange
            //var controller = new StudentController();

            // Act
            var result = Repository.Create(null);
            //Assert
            Assert.AreEqual(result, 0);
        }
    }
}