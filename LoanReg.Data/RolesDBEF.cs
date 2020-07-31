using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanReg.Data
{
    public class RolesDBEF : IRoles
    {
 
        
        private readonly LoanRegContext db;

        public RolesDBEF(LoanRegContext db)
        {
            this.db = db;
        }
        public Role CreateRole(Role createRole)
        {
            throw new NotImplementedException();
        }

        public IList<Role> GetAllRoles()
        {
            return db.Roles.OrderBy(r => r.Id).ToList();
        }

        public IList<Role> GetRoleByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public int GuardarCambios()
        {
            throw new NotImplementedException();
        }

        public Role UpdateRole(Role updateRole)
        {
            throw new NotImplementedException();
        }
    }
}
