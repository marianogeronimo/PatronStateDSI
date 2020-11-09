using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    class EnPreparacion : Estado
    {

        public EnPreparacion()
        {
            this.ambito = "DetalleDePedido";
            this.nombre = this.GetType().Name;
        }

        public override HistorialEstado buscarHistoriaActual()
        {
            throw new NotImplementedException();
        }

        public override HistorialEstado crearHistorialEstado()
        {
            throw new NotImplementedException();
        }

        public override Estado crearProximoEstado()
        {
            Estado estadoNuevo = new ListoParaServir();
            return estadoNuevo;
        }

        public override bool esEnPreparacion()
        {
            return true;
        }
        
        public override void finalizarPreparacion()
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

        //Metodos que no implementa

        public override void cancelar()
        {
            throw new NotImplementedException();
        }

        public override bool esCancelado()
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

        public override bool esPendienteDeServir()
        {
            throw new NotImplementedException();
        }

        public override bool esServido()
        {
            throw new NotImplementedException();
        }

        public override void notificar()
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
