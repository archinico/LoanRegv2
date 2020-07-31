using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Model
{
    public class Pagos
    {
        public int Id { get; set; }
        public int Monto { get; set; }
        public DateTime FechaPago { get; set; }
        //public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }
    }
}
