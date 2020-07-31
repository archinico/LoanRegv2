using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string Telefono { get; set; }
        public int Salario { get; set; }
        public string Correo { get; set; }
        public Sexo Sexo { get; set; }

        public EstadoCivil EstadoCivil { get; set; }
        public DateTime FechaNac { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Municipio { get; set; }
        public bool Trabaja { get; set; }
        public string EmpDireccion { get; set; }
        public string EmpNombre { get; set; }
        public DateTime EmpIngresoFech { get; set; }
        //public Solicitud SolicitudId { get; set; }

        //public Solicitud Solicitudes { get; set; }
        public List<Solicitud> Solicitudes { get; set; }
    }
}
