using LoanReg.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanReg.Data
{
    public class ClientesDBEF : IClientes
    {
        private readonly LoanRegContext db;

        public ClientesDBEF(LoanRegContext db)
        {
            this.db = db;
        }
        public Cliente CreateCliente(Cliente createCliente)
        {
            db.Clientes.Add(createCliente);

            return createCliente;
        }

        public Cliente DeleteCliente(int id)
        {
            var cliente = db.Clientes.Single(c => c.Id == id);
            db.Clientes.Remove(cliente);;

            return cliente;
        }

        public IList<Cliente> GelAllClients()
        {
            return db.Clientes.OrderBy(c => c.Id).ToList();
        }

        public Cliente GetClienteById(int id)
        {
            return db.Clientes.SingleOrDefault(c => c.Id == id);
        }

        public IList<Cliente> GetClienteByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetClientSolId(int id)
        {
            var user = 1;

            return db.Clientes.FromSqlRaw("EXECUTE dbo.GetClientDatafromsolicitudesId {0}", user).ToList();

        }

        public int GuardarCambios()
        {
            return db.SaveChanges();
        }

        public Cliente UpdateCliente(Cliente updateCliente)
        {
            var clienteSelected = db.Clientes.SingleOrDefault(s => s.Id == updateCliente.Id);
            clienteSelected.Nombre = updateCliente.Nombre;
            clienteSelected.Apellido = updateCliente.Apellido;
            clienteSelected.Cedula = updateCliente.Cedula;
            clienteSelected.Telefono = updateCliente.Telefono;
            clienteSelected.Salario = updateCliente.Salario;
            clienteSelected.Correo = updateCliente.Correo;
            clienteSelected.Sexo = updateCliente.Sexo;
            clienteSelected.EstadoCivil = updateCliente.EstadoCivil;
            clienteSelected.FechaNac = updateCliente.FechaNac;
            clienteSelected.Edad = updateCliente.Edad;
            clienteSelected.Direccion = updateCliente.Direccion;
            clienteSelected.Municipio = updateCliente.Municipio;
            clienteSelected.Trabaja = updateCliente.Trabaja;
            clienteSelected.EmpDireccion = updateCliente.EmpDireccion;
            clienteSelected.EmpNombre = updateCliente.EmpNombre;
            clienteSelected.EmpIngresoFech = updateCliente.EmpIngresoFech;

            return clienteSelected;
        }
    }
}
