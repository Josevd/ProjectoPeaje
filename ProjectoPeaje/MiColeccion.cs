using System;
using System.Collections.Generic;
using System.Linq;
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

        //-------------------


        /*
        pendientes que recuerdo
        -reporte tipo toString
        - en la clase programa donde va el menu va ser la validacion de datos
        
        
        
        */

    }
}
