using System;

namespace PatronStateDSI.Clases
{
    class HistorialEstado
    {
        Estado estado;
        DateTime fechaHoraFin;
        DateTime fechaHoraInicio;

        public HistorialEstado(Estado estado, DateTime fechaHoraFin, DateTime fechaHoraInicio)
        {
            this.estado = estado;
            this.fechaHoraFin = fechaHoraFin;
            this.fechaHoraInicio = fechaHoraInicio;
        }
    }
}