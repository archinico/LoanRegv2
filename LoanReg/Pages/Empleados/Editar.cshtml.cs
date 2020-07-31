using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanReg.Data;
using LoanReg.Dto;
using LoanReg.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoanReg.Pages
{
    public class EditarModel : PageModel
    {
        private readonly IEmpleados empleadosMethods;
        private readonly IRoles rolesMethods;
        private readonly IHtmlHelper helper;

        [BindProperty]
        public Empleado Empleados { get; set; }

        public SelectList Roles { get; set; }



        public EditarModel(IEmpleados empleadosMethods, IRoles rolesMethods, IHtmlHelper helper)
        {
            this.empleadosMethods = empleadosMethods;
            this.rolesMethods = rolesMethods;
            this.helper = helper;
        }

        public void OnGet(int? Id)
        {
            

            if (Id.HasValue)
            {
                Empleados = empleadosMethods.GetEmpleadoById(Id.Value);

                //Roles = rolesMethods.GetAllRoles().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Nombre }).ToList();
                Roles = new SelectList(rolesMethods.GetAllRoles(), "Id", "Nombre");
 
            }
            else 
            {
                Empleados = new Empleado();
            }
        }

        public ActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                if (Empleados.Id == 0)
                {
                    Empleados = empleadosMethods.CreateEmpleado(Empleados);
                    TempData["Mensaje"] = "Registro Creado Exitosamente";
                }
                else 
                {
                    Empleados = empleadosMethods.UpdateEmpleado(Empleados);
                    TempData["Mensaje"] = "Registro Actualizado Exitosamente";
                }

                empleadosMethods.GuardarCambios();

                return RedirectToPage("./Lista", new { Id = Empleados.Id });

            }

            return Page();
        }
    }
}