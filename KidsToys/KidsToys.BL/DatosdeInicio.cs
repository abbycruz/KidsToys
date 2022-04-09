using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsToys.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario1 = new Usuario();

            nuevoUsuario1.Nombre = "Kevin";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("123");

            contexto.Usuarios.Add(nuevoUsuario1);

            var nuevoUsuario2 = new Usuario();

            nuevoUsuario2.Nombre = "Abigail";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("456");

            contexto.Usuarios.Add(nuevoUsuario2);

            var nuevoUsuario3 = new Usuario();

            nuevoUsuario3.Nombre = "Daniel";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("789");

            contexto.Usuarios.Add(nuevoUsuario3);

            base.Seed(contexto);
        }
    }
}
