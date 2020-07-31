using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface IPrestamos
    {
        public Prestamo GetPrestamoById(int id);
        Prestamo CreatePrestamo(Prestamo createPrestamo);
        Prestamo UpdatePrestamo(Prestamo updatePrestamo);
        int GuardarCambios();

        public IList<Prestamo> GetPrestamobyId(int id);
    }
}
