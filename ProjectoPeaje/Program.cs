using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPeaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            /*RegistroVehicular carrito = new RegistroVehicular();
            carrito.
            Console.ReadLine();*/
            MiColeccion lista = new MiColeccion();
            lista.Agregar(1, 123, "10-10-2020", "12:00", 1, 5000, 20000, 15000);
            Console.WriteLine(lista.RegresaUnVehiculo(123));
            Console.WriteLine(lista.Buscar(123));
            Console.ReadLine();

        }
    }
}
