using System;
using System.Collections.Generic;
using System.Text;

namespace Broker
{
    class AgenteVendedor:IAgente
    {
        private string _nombre;
        private double _precioDeseado;
        public AgenteVendedor(string nombre,double precioDeseado)
        {
            this._nombre = nombre;
            this._precioDeseado = precioDeseado;
        }
        public void Actualizar(Accion accion)
        {
            if (accion.Precio > _precioDeseado)
            {
                Console.WriteLine($"Buen momento para vender {_nombre} la accion vale {accion.Precio- _precioDeseado}$ mas de su precio deseado!!");
            }
        }
    }
}
