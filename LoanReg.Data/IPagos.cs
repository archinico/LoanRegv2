using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface IPagos
    {
        public Pagos GetPagoById(int id);

        Pagos UpdatePago(Pagos updatePagos);
        Pagos CreatePagos(Pagos createPagos);

    }
}
