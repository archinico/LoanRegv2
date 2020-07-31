using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanReg.Data;
using LoanReg.Dto;
using LoanReg.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoanReg.Pages
{
    public class ListaModel : PageModel
    {
        public IEmpleados EmpleadosMethods;
        public IRoles RolesMethods;


        public IList<Empleado> Empleados { get; set; }

        public ListaModel(IEmpleados empleadosMethods)
        {
            EmpleadosMethods = empleadosMethods;
        }
        public void OnGet()
        {
            Empleados = EmpleadosMethods.GetEmpleadoWRole();
        }
    }
}