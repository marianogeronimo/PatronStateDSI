using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    class Mesa
    {
        int numeroMesa;
        int capacidadComensales;
        string nombreSeccion;
        string nombreMozo;

        public Mesa (int nroMesa, int capComensales, string nombreSeccion, string mozo)
        {
            this.NumeroMesa = nroMesa;
            this.CapacidadComensales = capComensales;
            this.NombreSeccion = nombreSeccion;
            this.NombreMozo = mozo;
        }

        public int NumeroMesa { get => numeroMesa; set => numeroMesa = value; }
        public string NombreSeccion { get => nombreSeccion; set => nombreSeccion = value; }
        public int CapacidadComensales { get => capacidadComensales; set => capacidadComensales = value; }
        public string NombreMozo { get => nombreMozo; set => nombreMozo = value; }
    }
}
