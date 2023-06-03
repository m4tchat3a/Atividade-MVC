using MVC_Login.BLL;
using MVC_Login.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // criar o obj DTO e receber dados do form
            LoginDTO loginDTO = new LoginDTO()
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            };

            // criar o obj BLL
            LoginBLL loginBLL = new LoginBLL();

            // chamar a BLL
            bool retorno = loginBLL.GetLoginBLL(loginDTO);

            // tratar o retorno
            if (retorno)
            {
                MessageBox.Show("Bem-vindo de volta!");
            } else
            {
                MessageBox.Show("Email ou senha inválidos");
            }
        }
    }
}
