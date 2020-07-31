using LoanReg.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Text;

namespace LoanReg.Data
{
    public class EmpleadosDBEF : IEmpleados
    {
        private readonly LoanRegContext db;
        private readonly IHtmlHelper helper;

        public EmpleadosDBEF(LoanRegContext db, IHtmlHelper helper)
        {
            this.db = db;
            this.helper = helper;
        }

        public Empleado CreateEmpleado(Empleado createEmpleado)
        {
            db.Empleados.Add(createEmpleado);

            return createEmpleado;
        }

        public Empleado Eliminar(int id)
        {
            var empleado = db.Empleados.Single(e => e.Id == id);
            db.Empleados.Remove(empleado);

            return empleado;
        }

        public IList<Empleado> GetAllEmpleados()
        {
            return db.Empleados.OrderBy(e => e.Id).ToList();
        }


        public Empleado GetEmpleadoById(int id)
        {
            return db.Empleados.SingleOrDefault(e => e.Id == id);
        }

        public IList<Empleado> GetEmpleadoByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public IList<Empleado> GetEmpleadoWRole()
        {
            return db.Empleados.Include(t => t.Role).OrderBy(e => e.Id).ToList();
        }

        public IList<Empleado> GetRoles(Empleado getRoles)
        {
            throw new NotImplementedException();
        }

        public int GuardarCambios()
        {
            return db.SaveChanges();
        }


        public Empleado UpdateEmpleado(Empleado updateEmpleado)
        {
            var empleadoSelected = db.Empleados.SingleOrDefault(e => e.Id == updateEmpleado.Id);
            empleadoSelected.Nombre = updateEmpleado.Nombre;
            empleadoSelected.Apellido = updateEmpleado.Apellido;
            empleadoSelected.Telefono = updateEmpleado.Telefono;
            empleadoSelected.Direccion = updateEmpleado.Direccion;
            empleadoSelected.Correo = updateEmpleado.Correo;
            empleadoSelected.Username = updateEmpleado.Username;
            empleadoSelected.Password = updateEmpleado.Password;
            empleadoSelected.RoleId = updateEmpleado.RoleId;


            return empleadoSelected;
        }

    }
}
