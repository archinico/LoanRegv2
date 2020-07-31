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
    public class DetallesModel : PageModel
    {
        private readonly ISolicitudes solicitudMethods;
        [BindProperty]
        public Solicitud Solicitudes { get; set; }
        [BindProperty]
        public Cliente Clientes { get; set; }

        public DetallesModel(ISolicitudes solicitudMethods)
        {
            this.solicitudMethods = solicitudMethods;
        }
        public ActionResult OnGet(int id)
        {
            Solicitudes = solicitudMethods.GetSolwClient(id);

            if (Solicitudes == null)
            {
                return RedirectToPage("./");
            }
            else
            {
                return Page();
            }
        }

        //public ActionResult OnPost()
        //{
        //    if (ModelState.IsValid)
        //    {

        //    }
        //    else
        //    {

        //    }

        //}
    }
}