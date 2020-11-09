namespace PatronState.Clases
{
    abstract class Estado
    {
        string ambito;
        string nombre;

       
        public abstract void buscarHistoriaActual();
        public abstract void cancelar();
        public abstract void crearHistorialEstado();
        public abstract Estado crearProximoEstado();
        public abstract bool esCancelado();
        public abstract bool esEnPreparacion();
        public abstract bool esNotificado();
        public abstract bool esPendienteDePreparacion();
        public abstract bool esPendienteDeServir();
        public abstract bool esServido();
        public abstract void finalizarPreparacion();
        public abstract string getAmbito();
        public abstract string getNombre();
        public abstract void notificar();
        public abstract void preparar();
        public abstract void servir();
        //new() supongo que ya esta incluido - en realidad creo que no podria por ser abstracto


    }


}