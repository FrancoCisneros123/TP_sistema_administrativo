using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Usuario
    {
        public int ValidarSesion(string textUsername,string textPassword)
        {
            if(string.IsNullOrWhiteSpace(textUsername) || string.IsNullOrWhiteSpace(textPassword))
                return 0;

            else
            {
                EntidadNegocio.Usuario[] usuarios = new EntidadNegocio.Usuario[5];

                for (int i = 0; i < 5; i++)
                    usuarios[i] = new EntidadNegocio.Usuario();

                usuarios[0].IdCategoria = 1;
                usuarios[0].Username = "admin";
                usuarios[0].Password = "admin123";

                usuarios[1].IdCategoria = 2;
                usuarios[1].Username = "vendedor";
                usuarios[1].Password = "vendedor123";

                usuarios[2].IdCategoria = 3;
                usuarios[2].Username = "gerente";
                usuarios[2].Password = "gerente123";

                usuarios[3].IdCategoria = 4;
                usuarios[3].Username = "stockLogistica";
                usuarios[3].Password = "stockLogistica123";

                usuarios[4].IdCategoria = 5;
                usuarios[4].Username = "repartidor";
                usuarios[4].Password = "repartidor123";

                foreach (EntidadNegocio.Usuario elemento in usuarios)
                {
                    if ((textUsername == elemento.Username) && (textPassword == elemento.Password))
                        return elemento.IdCategoria;
                }
            
                return 0;
            }
        }
    }
}
