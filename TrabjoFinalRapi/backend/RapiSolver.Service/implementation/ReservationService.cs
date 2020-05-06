using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service.implementation
{
    public class ReservationService : IReservationService
    {
        private IReservationRepository reservationRepository;
        public ReservationService(IReservationRepository reservationRepository)
        {
            this.reservationRepository = reservationRepository;
        }
        public bool Delete(int id)
        {
            return reservationRepository.Delete(id);
        }

        public Reservation Get(int id)
        {
            return reservationRepository.Get(id);
        }

        public IEnumerable<Reservation> GetAll()
        {
            return reservationRepository.GetAll();
        }

        public IEnumerable<ReservationViewModel> GetAllReservationsByUserId(int id)
        {
            return reservationRepository.GetAllReservationsByUserId(id);
        }

        public bool Save(Reservation entity)
        {
            return reservationRepository.Save(entity);
        }

        public bool Update(Reservation entity)
        {
            return reservationRepository.Update(entity);
        }
    }
}