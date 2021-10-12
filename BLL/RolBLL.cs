using Microsoft.EntityFrameworkCore;
using RegistroDeOrdenes.DAL;
using RegistroDeOrdenes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;


namespace RegistroDeOrdenes.BLL
{
    public class RolBLL
    {
        public static bool Guardar(Rol rol)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (contexto.Rol.Add(rol) != null)
                    paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Rol rol)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM RolDetalle where RolId={rol.RolId}");
                foreach (var anterior in rol.RolDetalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(rol).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var eliminar = contexto.Rol.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Rol Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Rol rol = new Rol();

            try
            {
                rol = contexto.Rol.Include(x => x.RolDetalle).Where(p => p.RolId == id).SingleOrDefault();
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return rol;
        }

        public static List<Rol> GetList(Expression<Func<Rol, bool>> rol)
        {
            List<Rol> lista = new List<Rol>();
            Contexto contexto = new Contexto();
            try
            {

            }
            catch
            {

            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

    }
}
