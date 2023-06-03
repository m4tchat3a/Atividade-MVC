using MVC_Login.DAL;
using MVC_Login.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Login.BLL
{
    internal class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            // criar obj da DAL
            LoginDAL loginDAL = new LoginDAL();

            // chamar a DAL
            return loginDAL.GetLoginDAL(loginDTO);
        }
    }
}
