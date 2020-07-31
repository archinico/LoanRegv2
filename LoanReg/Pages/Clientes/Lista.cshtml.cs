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
    public class ListaModel : PageModel
    {
        private readonly IClientes clienteMethods;

        public IList<Cliente> Clientes { get; set; }

        public ListaModel(IClientes clienteMethods)
        {
            this.clienteMethods = clienteMethods;
        }
        public void OnGet()
        {
            Clientes = clienteMethods.GelAllClients();
        }
    }
}