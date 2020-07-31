using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public class PrestamosDBEF : IPrestamos
    {
        private readonly LoanRegContext db;

        public PrestamosDBEF(LoanRegContext db)
        {
            this.db = db;
        }
        public Prestamo CreatePrestamo(Prestamo createPrestamo)
        {
            db.Prestamos.Add(createPrestamo);

            return createPrestamo;
        }

        public Prestamo GetPrestamoById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Prestamo> GetPrestamobyId(int id)
        {
            throw new NotImplementedException();
        }

        public int GuardarCambios()
        {
            throw new NotImplementedException();
        }

        public Prestamo UpdatePrestamo(Prestamo updatePrestamo)
        {
            throw new NotImplementedException();
        }
    }
}
