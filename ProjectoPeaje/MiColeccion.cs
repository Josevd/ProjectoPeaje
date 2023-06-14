using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPeaje
{
    internal class MiColeccion
    {

        
        RegistroVehicular[] MiArray =new RegistroVehicular[15];
        private int UltimoRegistro;



        public MiColeccion() {

            for (int i = 0; i < MiArray.Length; i++) {
                MiArray[i] = new RegistroVehicular();
                //UltimoRegistro = 0;
            }
        
        }

        //set y get del ultimo registro
        public int getUltimoRegistro() {
            return UltimoRegistro;
        }

        public void setUltimoRegistro(int UltimoRegistro) { 
            this.UltimoRegistro=UltimoRegistro;
        }
        //-----------------

        private bool lleno() { //verifica si la coleccion esta llena
            if (UltimoRegistro == 14)
            {
                return true;
            }
            else {
                return false;
            }
        }

        //agrega un registro si no esta llena la coleccion
        public string Agregar(int NumeroFactura, int NumeroPlaca, string Fecha, string Hora, int TipoDeVehículo, float MontoAPagar, float PagaCon, float Vuelto) {

            if (!lleno())
            {
                MiArray[UltimoRegistro].NumeroFactura = NumeroFactura;
                MiArray[UltimoRegistro].NumeroPlaca = NumeroPlaca;
                MiArray[UltimoRegistro].Fecha = Fecha;
                MiArray[UltimoRegistro].Hora = Hora;
                MiArray[UltimoRegistro].TipoDeVehículo = TipoDeVehículo;
                MiArray[UltimoRegistro].MontoAPagar = MontoAPagar;
                MiArray[UltimoRegistro].PagaCon = PagaCon;
                MiArray[UltimoRegistro].Vuelto = Vuelto;
                UltimoRegistro++;
                return "Registro exitoso";
            }
            else {
                return "Registro fallido, coleccion llena";
            }
            
        }


        public int Buscar(int NumeroPlaca) {// regresa el index en el arrayd e la coincidencia si esta existe y si no un -1
            for (int i = 0; i < MiArray.Length;i++) {
                if (MiArray[i].NumeroPlaca.Equals(NumeroPlaca)) {
                    return i;
                }
            }

            return -1;//osea no esta
        }


        public string RegresaUnVehiculo(int NumeroPlaca) {  //No sirve
            int index = Buscar(NumeroPlaca);
            if (index>-1) {
                return $"Numero de Factura: {MiArray[index].NumeroFactura}\nNumero de Placa: {MiArray[index].NumeroPlaca}\nFecha: {MiArray[index].Fecha}\nHora: {MiArray[index].Hora}\nTipo de vehículo: {MiArray[index].TipoDeVehículo}\nMonto pagado: {MiArray[index].MontoAPagar}\nPago con: {MiArray[index].PagaCon}\nVuelto: {MiArray[index].Vuelto}\n";
            }
            else { 
                return $"El vehiculo placa {NumeroPlaca} no existe.";
            }


            
        }

        public string Modificar(int NumeroPlaca) { //WIP cambiar mensajes por algo coherente
            int index = Buscar(NumeroPlaca);
            int opcion = 0;
            if (index > -1)
            {
                do
                {
                    Console.WriteLine("Seleccione el atributo a modificar: \n\n1. Numero de Factura\n2. Numero de Placa\n3. Fecha\n4. Hora\n5. Tipo de vehículo\n6. Monto pagado\n7. Pago con\n8. Vuelto\n9. Salir");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            MiArray[index].NumeroFactura = int.Parse(Console.ReadLine());
                            return $"El atributo Numero de Factura del vehiculo placa {NumeroPlaca} Fue actualizado.";
                            break;
                        case 2:
                            MiArray[index].NumeroPlaca = int.Parse(Console.ReadLine());
                            return $"El atributo Numero de Placa del vehiculo placa {NumeroPlaca} Fue actualizado.";
                            break;
                        case 3:
                            MiArray[index].Fecha = Console.ReadLine();
                            return $"El atributo Fecha del vehiculo placa {NumeroPlaca} Fue actualizado.";
                            break;
                        case 4:
                            MiArray[index].Hora = Console.ReadLine();
                            return $"El atributo Hora del vehiculo placa {NumeroPlaca} Fue actualizado.";
                            break;
                        case 5:
                            MiArray[index].TipoDeVehículo = int.Parse(Console.ReadLine());
                            return $"El atributo Tipo de vehículo del vehiculo placa {NumeroPlaca} Fue actualizado.";
                            break;
                        case 6:
                            MiArray[index].MontoAPagar = float.Parse(Console.ReadLine());
                            return $"El atributo Monto pagado del vehiculo placa {NumeroPlaca} Fue actualizado.";
                            break;
                        case 7:
                            MiArray[index].PagaCon = float.Parse(Console.ReadLine());
                            return $"El atributo Pago con del vehiculo placa {NumeroPlaca} Fue actualizado.";
                            break;
                        case 8:
                            MiArray[index].Vuelto = float.Parse(Console.ReadLine());
                            return $"El atributo Vuelto del vehiculo placa {NumeroPlaca} Fue actualizado.";
                            break;

                        default:
                            opcion = 0;
                            return $"Default";
                            break;

                    }

                } while (opcion != 9);
                
            }

            else
            {
                return $"El vehiculo placa {NumeroPlaca} no existe.";
            }


        }



        //-------------------


        /*
        pendientes que recuerdo
        -reporte tipo toString
        - en la clase programa donde va el menu va ser la validacion de datos
        
        
        
        */

    }
}
