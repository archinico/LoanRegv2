using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanReg.Data;
using LoanReg.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoanReg.Pages.Solicitudes
{
    public class ListaModel : PageModel
    {
        private readonly ISolicitudes solicitudesMethods;
        public IList<Solicitud> Solicitudes { get; set; }

        public ListaModel(ISolicitudes solicitudesMethods)
        {
            this.solicitudesMethods = solicitudesMethods;
        }
        public void OnGet()
        {
            Solicitudes = solicitudesMethods.GetSolWClientName();
        }
    }
}