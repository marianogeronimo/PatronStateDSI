using System;
namespace PatronState.Clases
{
    abstract class Estado
    {
        internal string ambito;
        internal string nombre;
        internal HistorialEstado historialReferenciado;

        public string Ambito { get => ambito; set => ambito = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal HistorialEstado HistorialReferenciado { get => historialReferenciado; set => historialReferenciado = value; }

        public abstract HistorialEstado buscarHistoriaActual();
        public abstract void cancelar();
        public abstract Estado crearProximoEstado();
        public abstract HistorialEstado crearHistorialEstado(DateTime fechaInicio);
        public abstract bool esCancelado();
        public abstract bool esEnPreparacion();
        public abstract bool esNotificado();
        public abstract bool esPendienteDePreparacion();
        public abstract bool esPendienteDeServir();
        public abstract bool esServido();
        public abstract void finalizarPreparacion();
        public abstract string getAmbito();
        public abstract string getNombre();
        public abstract void notificar(DateTime fechaHoraActual, DetallePedido detalle);
        public abstract void preparar();
        public abstract void servir();
        //new() supongo que ya esta incluido - en realidad creo que no podria por ser abstracto



    }


}