using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanReg.Data;
using LoanReg.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoanReg.Pages.Empleados
{
    public class DetallesModel : PageModel
    {
        private readonly IEmpleados empleadosMethods;
        public Empleado Empleados { get; set; }

        public DetallesModel(IEmpleados empleadosMethods)
        {
            this.empleadosMethods = empleadosMethods;
        }
        public IActionResult OnGet(int id)
        {
            Empleados = empleadosMethods.GetEmpleadoById(id);

            if (Empleados == null)
            {
                return RedirectToPage("");
            }
            else 
            {
                return Page();
            }
        }
    }
}