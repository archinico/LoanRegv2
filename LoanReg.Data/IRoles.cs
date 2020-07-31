using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface IRoles
    {
        IList<Role> GetRoleByName(string nombre);
        Role CreateRole(Role createRole);
        Role UpdateRole(Role updateRole);
        int GuardarCambios();

        IList<Role> GetAllRoles();
        
    }
}
