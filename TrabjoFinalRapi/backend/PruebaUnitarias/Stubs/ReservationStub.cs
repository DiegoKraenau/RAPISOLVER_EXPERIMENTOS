using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class ReservationStub
    {
        public static Reservation reservation_1 = new Reservation()
        {
            ReservationId = 1,
            Fecha = "14 de abril",
            Note = "Reserva numero 1"
        };

        public static Reservation reservation_2 = new Reservation()
        {
            ReservationId = 2,
            Fecha = "16 de Agosto",
            Note = "Reserva numero 2"
        };

        public static List<Reservation> reservationList = new List<Reservation>(new Reservation[] { reservation_1, reservation_2 });

    }
}