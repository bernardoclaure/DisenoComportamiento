using System;
using System.Collections.Generic;
using System.Text;

namespace Broker
{
    public interface IAgente
    {
        void Actualizar(Accion accion);
    }
}
