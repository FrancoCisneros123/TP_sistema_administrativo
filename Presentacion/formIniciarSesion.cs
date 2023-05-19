using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class formIniciarSesion : Form
    {
        public formIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int tipoPerfil;
            Negocio.Usuario usuarioLogeado = new Negocio.Usuario();

            tipoPerfil = usuarioLogeado.ValidarSesion(txtbNombreUsuario.Text, txtbPassword.Text);

            if (tipoPerfil == 0)
                MessageBox.Show("El nombre de usuario o contraseña es incorrecto");

            else
            {
                this.Hide();
                MessageBox.Show("Se ha iniciado sesion correctamente");
                Form formularioInicio; 
                switch (tipoPerfil)
                {
                    case 1:
                        MessageBox.Show("Inicio de sesión como Administrador");
                        formularioInicio = new formAdministradorInicio();
                        formularioInicio.ShowDialog();
                        break;

                    case 2:
                        MessageBox.Show("Inicio de sesión como Vendedor");
                        formularioInicio = new formVendedorInicio();
                        formularioInicio.ShowDialog();
                        break;

                    case 3:
                        MessageBox.Show("Inicio de sesión como Gerente");
                        formularioInicio = new formGerenteInicio();
                        formularioInicio.ShowDialog();
                        break;
                       
                    case 4: 
                         MessageBox.Show("Inicio de sesión como Encargado de stock y logísticas");
                         formularioInicio = new formEncargadoInicio();
                         formularioInicio.ShowDialog();
                         break;

                    case 5:
                         MessageBox.Show("Inicio de sesión como Repartidor");
                         formularioInicio = new formRepartidorInicio();
                         formularioInicio.ShowDialog();
                         break;

                    default:
                        break;
                };

                Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
