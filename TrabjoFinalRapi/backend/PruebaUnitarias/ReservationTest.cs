using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PruebaUnitarias.MockRepositories;
using PruebaUnitarias.Stubs;
using RapiSolver.Repository;
using RapiSolver.Service;
using RapiSolver.Service.implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias
{
    [TestClass]
    public class ReservationTest
    {
        private static IReservationService _reservationService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IReservationRepository> _reservationRepository = new ReservationRepositoryMock().reservationRepository;
            _reservationService = new ReservationService(_reservationRepository.Object);

        }
        [TestMethod]
        public void Save_ObjReservation_ReturnTrue()
        {
            var result = _reservationService.Save(ReservationStub.reservation_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetAll_Empty_ReturnReservationList()
        {
            var result = _reservationService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);
        }
        [TestMethod]
        public void GetById_SingleNumber_ReturnReservation()
        {
            var result = _reservationService.Get(1);
            result.ReservationId.Should().Be(1);
            result.Fecha.Should().NotBeNullOrEmpty();
            result.Note.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public void UpdateById_ObjReservation_ReturnTrue()
        {
            var result = _reservationService.Update(ReservationStub.reservation_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {
            var result = _reservationService.Delete(1);
            Assert.AreEqual(true, result);
        }
    }
}

