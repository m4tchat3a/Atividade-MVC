using MVC_Login.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Login.DAL
{
    internal class LoginDAL
    {
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            // checa se email e senha são do ADM e valida
            if (loginDTO.Email == "admin@admin.com" && loginDTO.Senha == "1234")
            {
                return true;
            }

            return false;
        }
    }
}
