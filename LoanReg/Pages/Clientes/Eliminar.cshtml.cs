using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanReg.Data;
using LoanReg.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoanReg.Pages.Clientes
{
    public class EliminarModel : PageModel
    {
        private readonly IClientes clienteMethods;

        public Cliente Clientes { get; set; }
        public EliminarModel(IClientes clienteMethods)
        {
            this.clienteMethods = clienteMethods;
        }
        public void OnGet(int id)
        {
            Clientes = clienteMethods.GetClienteById(id);
        }

        public ActionResult OnPost(int id)
        {
            var clientes = clienteMethods.DeleteCliente(id);
            clienteMethods.GuardarCambios();
            TempData["DeleteValidation"] = $"Se ha eliminado correctamente {clientes.Nombre}";

            return RedirectToPage("./Lista");
        }
    }
}