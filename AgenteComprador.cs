using System;
using System.Collections.Generic;
using System.Text;

namespace Broker
{
    class AgenteComprador : IAgente
    {
        private string _nombre;
        private double _precioDeseado;
        public AgenteComprador(string nombre, double precioDeseado)
        {
            this._nombre = nombre;
            this._precioDeseado = precioDeseado;
        }
        public void Actualizar(Accion accion)
        {
            if (accion.Precio < _precioDeseado)
            {
                Console.WriteLine($"Buen momento para comprar {_nombre} la accion esta {_precioDeseado-accion.Precio}$ menos de su precio deseado! ");
            }
        }
    }
}
