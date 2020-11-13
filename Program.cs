using System;

namespace Broker
{
    class Program
    {
        static void Main(string[] args)
        {
            var googleAccion = new AccionGoogle(50);
            var agenteVendedor = new AgenteVendedor("Bernardo", 60);
            var agenteComprador= new AgenteComprador("Pablo", 40);
            var agenteComprador2 = new AgenteComprador("Diego", 35);
            googleAccion.Attach(agenteComprador);
            googleAccion.Attach(agenteVendedor);
            googleAccion.Attach(agenteComprador2);
            Console.WriteLine("La accion de google sube a 75$");
            googleAccion.Precio = 75;
            Console.WriteLine("La accion de google baja a 30$");
            googleAccion.Precio = 30;



        }
    }
}
