﻿using Microsoft.EntityFrameworkCore;
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
            if(!Existe(rol.RolId))
                return Insertar(rol);
            else
                return Modificar(rol);
        }
        private static bool Insertar(Rol rol)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            { 
                contexto.Rol.Add(rol);
                paso = contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Rol.Any(r => r.RolId == id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        public static bool Modificar(Rol rol)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM RolDetalle where RolId={rol.RolId}");

                foreach (var item in rol.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(rol).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch(Exception)
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
                
                var rol = RolBLL.Buscar(id);

                if (rol != null)
                {
                    contexto.Rol.Remove(rol);
                    paso = contexto.SaveChanges() > 0;
                }

            }
            catch (Exception)
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
                rol = contexto.Rol.Include(x => x.Detalle).
                    Where(p => p.RolId == id).
                    SingleOrDefault();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return rol;
        }

        public static List<Rol> GetList(Expression<Func<Rol, bool>> criterio)
        {
            List<Rol> lista = new List<Rol>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Rol.Where(criterio).ToList();
            }
            catch(Exception)
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
