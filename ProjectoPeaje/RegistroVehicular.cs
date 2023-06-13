using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPeaje
{
    internal class RegistroVehicular
    {
        public int NumeroFactura { get; set; }
        public int NumeroPlaca { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int TipoDeVehículo { get; set; }
        public float MontoAPagar { get; set; }
        public float PagaCon { get; set; }
        public float Vuelto { get; set; }


        public RegistroVehicular() {

            NumeroFactura = 0;
            NumeroPlaca = 0;
            Fecha = "";
            Hora = "";
            TipoDeVehículo = 0;
            MontoAPagar = 0;
            PagaCon = 0;
            Vuelto = 0;

        }

        public RegistroVehicular(int NumeroFactura, int NumeroPlaca, string Fecha, string Hora, int TipoDeVehículo, float MontoAPagar, float PagaCon, float Vuelto)
        {
            this.NumeroFactura = 0;
            this.NumeroPlaca = 0;
            this.Fecha = "";
            this.Hora = "";
            this.TipoDeVehículo = 0;
            this.MontoAPagar = 0;
            this.PagaCon = 0;
            this.Vuelto = 0;
        }

        


    }
}
