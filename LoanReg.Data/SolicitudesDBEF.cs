using LoanReg.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanReg.Data
{
    public class SolicitudesDBEF : ISolicitudes
    {
        private readonly LoanRegContext db;

        public SolicitudesDBEF(LoanRegContext db)
        {
            this.db = db;
        }
        public Solicitud CreateSolicitud(Solicitud createSolicitud)
        {
            db.Solicitudes.Add(createSolicitud);

            return createSolicitud;
        }

        public IList<Solicitud> GetSolbyClientId(int id)
        {
            //var search = Convert.ToInt32(id);

            var Cliente = db.Solicitudes.FromSqlInterpolated($"select * from Solicitudes({id})")
                .Include(b => b.Cliente)
                .ToList();

            return Cliente;
        }

        public Solicitud GetSolicitudById(int id)
        {
            return db.Solicitudes.Include(s => s.Cliente).SingleOrDefault(s => s.Id == id);
        }

        public Solicitud GetSolwClient(int id)
        {
            return db.Solicitudes.Include(s => s.Cliente).SingleOrDefault(s => s.Id == id);
        }

        public IList<Solicitud> GetSolWClientName()
        {
            return db.Solicitudes.Include(s => s.Cliente).OrderBy(s => s.Id).ToList();
        }

        public int GuardarCambios()
        {
            return db.SaveChanges();
        }

        public Solicitud UpdateSolicitud(Solicitud updateSolicitud)
        {
            var solicitudSelected = db.Solicitudes.SingleOrDefault(s => s.Id == updateSolicitud.Id);
            solicitudSelected.ClienteId = updateSolicitud.ClienteId;
            solicitudSelected.Estado = updateSolicitud.Estado;
            solicitudSelected.MontoSolicitado = updateSolicitud.MontoSolicitado;
            solicitudSelected.FechaSolicitud = updateSolicitud.FechaSolicitud;
            solicitudSelected.Interes = updateSolicitud.Interes;
            solicitudSelected.Cuotas = updateSolicitud.Cuotas;
            solicitudSelected.TipoPago = updateSolicitud.TipoPago;

            return solicitudSelected;
        }
    }
}
