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
    public class EliminarModel : PageModel
    {
        private readonly IEmpleados empleadosMethods;

        public Empleado Empelados { get; set; }

        public EliminarModel(IEmpleados empleadosMethods)
        {
            this.empleadosMethods = empleadosMethods;
        }
        public void OnGet(int id)
        {
            this.Empelados = empleadosMethods.GetEmpleadoById(id);
        }

        public ActionResult OnPost(int Id)
        {
            var empleados = empleadosMethods.Eliminar(Id);
            empleadosMethods.GuardarCambios();
            TempData["DeleteValidation"] = $"Se ha eliminado correctamente {empleados.Nombre}";

            return RedirectToPage("./Detalles");

        }
    }
}