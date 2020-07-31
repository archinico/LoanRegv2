using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface ISolicitudes
    {
        public Solicitud GetSolicitudById(int id);
        Solicitud CreateSolicitud(Solicitud createSolicitud);
        Solicitud UpdateSolicitud(Solicitud updateSolicitud);
        int GuardarCambios();
        public IList<Solicitud> GetSolbyClientId(int id);
        IList<Solicitud> GetSolWClientName();
        /// <summary>
        /// Este metodo me va a devolver las solicitudes con la data de la tabla cliente
        /// </summary>
        /// <returns></returns>
        Solicitud GetSolwClient(int id);
    }
}
