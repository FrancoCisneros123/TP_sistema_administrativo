using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadNegocio
{
    public class Usuario
    {
        private string username;
        private string password;
        private int idCategoria;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
    }
}
