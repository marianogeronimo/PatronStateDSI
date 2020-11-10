using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    class HistorialEstado
    {
        private DateTime fechaHoraFin;
        private DateTime fechaHoraInicio;
        private Estado estado;

        public HistorialEstado(DateTime fechaInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaInicio;
            conocerEstado(estado);
        }

        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        internal Estado Estado { get => estado; set => estado = value; }

        public void conocerEstado(Estado estado)
        {
            this.estado = estado;
            this.estado.HistorialReferenciado = this;
        }

        public void setFechaFinEstado(DateTime fechaHoraActual)
        {
            FechaHoraFin = fechaHoraActual;
        }


    }
}
