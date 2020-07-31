using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Model
{
    public class Solicitud
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        public int ClienteId { get; set; }
        public int MontoSolicitado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public int Interes { get; set; }
        public int Cuotas { get; set; }

        public TipoPago TipoPago { get; set; }
        public Cliente Cliente { get; set; }

        public Prestamo Prestamo { get; set; }

        //public List<Cliente> Clientes { get; set; }
    }
}
