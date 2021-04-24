using LittleMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Classes.Core
{
    public class UsuarioCore
    {
        LittleMarketBDContext dbContext;
        public UsuarioCore(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Usuario> GetAll()
        {
            try
            {
                //LinQ
                //Funciones
                //Lenguaje
                //SELECT * FROM Usuario
                List<Usuario> usuarios = (
                    (List<Usuario>)(from u in dbContext.Usuario
                    where u.Activo == true
                    select new
                    {
                        Nombre = u.Nombre,
                        ApellidoP = u.ApellidoPaterno,
                        ApellidoM = u.ApellidoMaterno
                    })
                    );

                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(Usuario usuario)
        {
            try
            {
                bool validarUsuario = Validate(usuario);
               
                if (validarUsuario)
                {

                    dbContext.Add(usuario);
                    dbContext.SaveChanges();

                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Validate (Usuario usuario)
        {

             try
            {
               if (String.IsNullOrEmpty(usuario.Nombre) /*|| String.IsNullOrEmpty(usuario.ApellidoMaterno
                     || String.IsNullOrEmpty(usuario.ApellidoPaterno   || String.IsNullOrEmpty(usuario.Ciudad
                      || String.IsNullOrEmpty(usuario.Contra
                       || String.IsNullOrEmpty(usuario.Correo
                        || String.IsNullOrEmpty(usuario.Direccion*/){

                    return true;
                }
                return true;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
