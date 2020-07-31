using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface IClientes
    {
        IList<Cliente> GetClienteByName(string nombre);

        Cliente GetClienteById(int id);

        Cliente UpdateCliente(Cliente updateCliente);

        Cliente CreateCliente(Cliente createCliente);
        int GuardarCambios();

        //public IList<Cliente> GetclientbySol(int id);

        public IList<Cliente> GetClientSolId(int id);

        IList<Cliente> GelAllClients();

        Cliente DeleteCliente(int id);


    }
}
