using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PruebaUnitarias.MockRepositories;
using PruebaUnitarias.Stubs;
using RapiSolver.Api.Controllers;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Service;
using RapiSolver.Service.implementation;
using System.Collections;
using System.Collections.Generic;

namespace PruebaUnitarias
{
    [TestClass]
    public class LocationTest
    {
        private static ILocationService _locationService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<ILocationRepository> _locationRepository = new LocationRepositoryMock().locationRepository;

            _locationService = new LocationService(_locationRepository.Object);

        }
        [TestMethod]
        public void Save_ObjLocation_ReturnTrue()
        {
            
            var result = _locationService.Save(LocationStub.location_1);
            Assert.AreEqual(true, result);
        

        }
      
        [TestMethod]
        public void GetAll_Empty_ReturnLocationList()
        {

            var result = _locationService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);


        }
        [TestMethod]
        public void GetById_SingleNumber_ReturnLocation()
        {
            var result = _locationService.Get(1);

            result.LocationId.Should().Be(1);
            result.Country.Should().NotBeNullOrEmpty();
            result.Country.Should().Be("Lima");
            result.City.Should().Be("Lima");
            result.State.Should().Be("Lima");
            result.Address.Should().Be("av.Venezuela");


        }

        [TestMethod]
        public void UpdateById_ObjLocation_ReturnTrue()
        {
            var result = _locationService.Update(LocationStub.location_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {

            var result = _locationService.Delete(1);
            Assert.AreEqual(true, result);

        }
    }
        



}
