using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class ReservationRepositoryMock
    {
        public Mock<IReservationRepository> reservationRepository { get; set; }

        public ReservationRepositoryMock()
        {
            reservationRepository = new Mock<IReservationRepository>();
            Setup();
        }

        private void Setup()
        {
            reservationRepository.Setup((x) => x.Save(It.IsAny<Reservation>())).Returns(true);
            reservationRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(ReservationStub.reservation_1);
            reservationRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            reservationRepository.Setup((x) => x.GetAll()).Returns(ReservationStub.reservationList);
            reservationRepository.Setup((x) => x.Update(It.IsAny<Reservation>())).Returns(true);
        }
    }
}
