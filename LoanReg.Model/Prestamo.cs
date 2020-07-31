using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Model
{
    public class Prestamo
    {
        public int Id { get; set; }
        //public int Monto { get; set; }
        //public int Interes { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        //public int Cuotas { get; set; }
        public int BalPendiente { get; set; }
        public int PagosPendientes { get; set; }
        public DateTime FechaLlimite { get; set; }
        public string MoneyFrom { get; set; }
        public string MoneyTo { get; set; }
        public int SolicitudId { get; set; }
        public Solicitud Solicitud { get; set; }
        public Pagos Pagos { get; set; }
    }
}
