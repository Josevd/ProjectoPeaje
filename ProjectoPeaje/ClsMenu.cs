using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPeaje
{
    internal class ClsMenu
    {

        private static int opcion = 0;
        private static MiColeccion lista = new MiColeccion();

        public ClsMenu() {
            /*opcion = 0;
            lista = new MiColeccion();*/
        }

        public static void Menu()
        {
            do
            {
                Console.WriteLine("1. Ingresar Paso Vehicular");
                Console.WriteLine("2. Consulta de Vehiculos");
                Console.WriteLine("3. Modificar Datos de Vehiculos");
                Console.WriteLine("4. Reporte de Datos Vehiculares");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Digite una de las opciones: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: lista.Agregar(1, 123, 1, 15000, 240000, 15000); break;
                    case 2: Console.WriteLine(lista.RegresaUnVehiculo(123)); break;
                    case 3: lista.Modificar(123); break;
                    case 4: lista.ReporteGeneral(); break;
                    default: break;
                }
            }
            while (opcion!=5);
        }


    }
}
