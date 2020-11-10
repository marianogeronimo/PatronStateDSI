﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    class ListoParaServir : Estado
    {

        public ListoParaServir()
        {
            this.ambito = "DetalleDePedido";
            this.nombre = this.GetType().Name;
        }

        public override HistorialEstado buscarHistoriaActual()
        {
            throw new NotImplementedException();
        }

        public override HistorialEstado crearHistorialEstado(DateTime fechaInicio)
        {
            HistorialEstado nuevo = new HistorialEstado(fechaInicio, this);
            return nuevo;
        }

        public override Estado crearProximoEstado()
        {
            Estado estadoNuevo = new Notificado();
            return estadoNuevo;
        }

        public override bool esPendienteDeServir()
        {
            throw new NotImplementedException();
        }

        public override string getAmbito()
        {
            return ambito;
        }

        public override string getNombre()
        {
            return nombre;
        }

        public override void notificar(DateTime fechaHoraActual, DetallePedido detalle)
        {
            historialReferenciado.setFechaFinEstado(fechaHoraActual);
            Estado nuevoEstado = crearProximoEstado();
            HistorialEstado nuevoHistorial = crearHistorialEstado(fechaHoraActual);
            detalle.agregarHistorial(nuevoHistorial);
            detalle.setEstadoActual(nuevoEstado);
        }

        //Metodos que no implementa

        public override void cancelar()
        {
            throw new NotImplementedException();
        }

        public override bool esCancelado()
        {
            throw new NotImplementedException();
        }

        public override bool esEnPreparacion()
        {
            throw new NotImplementedException();
        }

        public override bool esNotificado()
        {
            throw new NotImplementedException();
        }

        public override bool esPendienteDePreparacion()
        {
            throw new NotImplementedException();
        }

        public override bool esServido()
        {
            throw new NotImplementedException();
        }

        public override void finalizarPreparacion()
        {
            throw new NotImplementedException();
        }

        public override void preparar()
        {
            throw new NotImplementedException();
        }

        public override void servir()
        {
            throw new NotImplementedException();
        }
    }
}
