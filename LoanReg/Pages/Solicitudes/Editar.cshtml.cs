using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanReg.Data;
using LoanReg.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoanReg
{
    public class EditarModel : PageModel
    {
        private readonly ISolicitudes solicitudesMethods;
        private readonly IHtmlHelper helper;
        private readonly IClientes clienteMEthods;
        private readonly IPrestamos prestamoMethods;

        [BindProperty]
        public Solicitud Solicitudes { get; set; }
        [BindProperty]
        public Cliente Clientes { get; set; }
        [BindProperty]
        public Prestamo Prestamos { get; set; }

        public IEnumerable<SelectListItem> TipoPago {get;set;}
        public IEnumerable<SelectListItem> Sexo { get; set; }

        public IEnumerable<SelectListItem> EstadoCivil { get; set; }

        public EditarModel(ISolicitudes solicitudesMethods, IHtmlHelper helper, IClientes clienteMEthods, IPrestamos prestamoMethods)
        {
            this.solicitudesMethods = solicitudesMethods;
            this.helper = helper;
            this.clienteMEthods = clienteMEthods;
            this.prestamoMethods = prestamoMethods;
        }

        public void OnGet(int? Id)
        {
            TipoPago = helper.GetEnumSelectList<TipoPago>();

            Sexo = helper.GetEnumSelectList<Sexo>();

            EstadoCivil = helper.GetEnumSelectList<EstadoCivil>();

            if (Id.HasValue)
            {
                Solicitudes = solicitudesMethods.GetSolicitudById(Id.Value);
                //Clientes = clienteMEthods.GetClientSolId(Id.Value);
            }
            else
            {
                Solicitudes = new Solicitud();
                Clientes = new Cliente();
            }
        }

        public ActionResult OnPost()
        {
            TipoPago = helper.GetEnumSelectList<TipoPago>();

            Sexo = helper.GetEnumSelectList<Sexo>();

            EstadoCivil = helper.GetEnumSelectList<EstadoCivil>();

            if (ModelState.IsValid)
            {
                if (Solicitudes.Id == 0)
                {
                    Solicitudes = solicitudesMethods.CreateSolicitud(Solicitudes);
                    Clientes = clienteMEthods.CreateCliente(Clientes);
                }
                else
                {
                    if (Solicitudes.Estado == true)
                    {
                        Prestamos = prestamoMethods.CreatePrestamo(Prestamos);
                        Solicitudes = solicitudesMethods.UpdateSolicitud(Solicitudes);

                    }
                    else
                    {
                        Solicitudes = solicitudesMethods.UpdateSolicitud(Solicitudes);
                    }
                    
                }

                solicitudesMethods.GuardarCambios();
                clienteMEthods.GuardarCambios();
                return RedirectToPage("./Detalles", new { Id = Solicitudes.Id });
            }

            return Page();
        }
    }
}