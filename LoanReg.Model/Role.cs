using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
