using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanReg.Data;
using LoanReg.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoanReg.Pages.Clientes
{
    public class EditarModel : PageModel
    {
        private readonly IClientes clienteMethods;
        private readonly IHtmlHelper helper;

        public IEnumerable<SelectListItem> Sexo { get; set; }

        public IEnumerable<SelectListItem> EstadoCivil { get; set; }
        [BindProperty]
        public Cliente Clientes { get; set; }

        public EditarModel(IClientes clienteMethods, IHtmlHelper helper)
        {
            this.clienteMethods = clienteMethods;
            this.helper = helper;
        }
        public void OnGet(int? Id)
        {
            Sexo = helper.GetEnumSelectList<Sexo>();

            EstadoCivil = helper.GetEnumSelectList<EstadoCivil>();

            if (Id.HasValue)
            {
                Clientes = clienteMethods.GetClienteById(Id.Value);
                //Clientes = clienteMEthods.GetClientSolId(Id.Value);
            }
            else
            {
                Clientes = new Cliente();
            }
        }

        public ActionResult OnPost()
        {
            Sexo = helper.GetEnumSelectList<Sexo>();

            EstadoCivil = helper.GetEnumSelectList<EstadoCivil>();

            if (ModelState.IsValid)
            {
                if (Clientes.Id == 0)
                {
                    Clientes = clienteMethods.CreateCliente(Clientes);
                }
                else
                {
                    Clientes = clienteMethods.UpdateCliente(Clientes);
                }

                clienteMethods.GuardarCambios();
                return RedirectToPage("./Detalles", new { Id = Clientes.Id });
            }

            return Page();
        }
    }
}