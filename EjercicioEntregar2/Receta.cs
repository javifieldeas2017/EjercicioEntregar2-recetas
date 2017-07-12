using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Receta
    {
        public string NombreAlimento1 { get; set; }
        public string NombreAlimento2 { get; set; }
        public float Peso1 { get; set; }
        public float Peso2 { get; set; }

        public Receta()
        {
            NombreAlimento1 = null;
            NombreAlimento2 = null;
            Peso1 = 0;
            Peso2 = 0;
        }

        public Receta(Alimento _Alimento1, Alimento _Alimento2)
        {
            this.NombreAlimento1 = _Alimento1.Nombre;
            this.NombreAlimento2 = _Alimento2.Nombre;
            this.Peso1 = _Alimento1.Peso;
            this.Peso2 = _Alimento2.Peso;
        }
    }

}
