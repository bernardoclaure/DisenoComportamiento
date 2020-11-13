using System;
using System.Collections.Generic;
using System.Text;

namespace Broker
{
    public abstract class Accion
    {

        private double _precio;
        private List<IAgente> _agentes= new List<IAgente>();
        public Accion(double precio)
        {
            _precio = precio;
        }
        public void Attach(IAgente agente)
        {
            _agentes.Add(agente);
        }

        public void Detach(IAgente agente)
        {
            _agentes.Remove(agente);
        }

        public void Notificar()
        {
            foreach (IAgente agente in _agentes)
            {
                agente.Actualizar(this);
            }

        }
        public double Precio
        {
            get { return _precio; }
            set
            {
                if (_precio != value)
                {
                    _precio = value;
                    Notificar(); 
                }
            }
        }
     

    }
}
