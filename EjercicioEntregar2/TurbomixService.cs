using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class TurbomixService
    {
        public IBascula Bascula { get; set; }
        public ICocina Cocina { get; set; }

        public TurbomixService(IBascula _Bascula, ICocina _Cocina)
        {
            this.Bascula = _Bascula;
            this.Cocina = _Cocina;
        }

        public Plato PrepararPlato(Alimento mAlimento1, Alimento mAlimento2, Receta receta)
        {
            float Peso1 = Bascula.Pesar(mAlimento1);
            float Peso2 = Bascula.Pesar(mAlimento2);
            //Fresco o calentado
            if (mAlimento1.Calentado || mAlimento2.Calentado) return null;
            //Coincidencia de nombres
            if (mAlimento1.Nombre != receta.NombreAlimento1 & mAlimento1.Nombre != receta.NombreAlimento2)
                return null;
            if (mAlimento2.Nombre != receta.NombreAlimento1 & mAlimento2.Nombre != receta.NombreAlimento2)
                return null;
            //Si llega aqui, los nombres coinciden. Comprobacion de pesos
            if (mAlimento1.Nombre == receta.NombreAlimento1)
                if (mAlimento1.Peso < receta.Peso1) return null;
            if (mAlimento1.Nombre == receta.NombreAlimento2)
                if (mAlimento1.Peso < receta.Peso2) return null;
            if (mAlimento2.Nombre == receta.NombreAlimento1)
                if (mAlimento2.Peso < receta.Peso1) return null;
            if (mAlimento2.Nombre == receta.NombreAlimento2)
                if (mAlimento2.Peso < receta.Peso2) return null;

            Cocina.Calentar(mAlimento1, mAlimento2);

            return new Plato(mAlimento1, mAlimento2);
        }

    }
}
