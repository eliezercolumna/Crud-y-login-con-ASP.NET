using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using AprendeAsp.Models.db;

namespace AprendeAsp.Models
{
    public class PeliculasModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Actores { get; set; }
        public string Año { get; set; }
        public string Sipnosis { get; set; }

        public List<PeliculasModel> get()
        {
            using (var cn = Conexion.Conectar()){
                string sql = "SELECT * FROM peliculas";
                return cn.Query<PeliculasModel>(sql).ToList();
            }
        }
        
        public List<PeliculasModel> getId(int id)
        {
            using(var cn = Conexion.Conectar()){
                string sql = "SELECT * FROM peliculas WHERE id = '" + id + "'";
                return cn.Query<PeliculasModel>(sql).ToList();
            }  
        }

        public bool Insert(PeliculasModel model)
        {
            using (var cn = Conexion.Conectar())
            {
                string sql = "INSERT INTO peliculas(nombre,autor,actores,año,sipnosis) VALUES('"+model.Nombre+"','"+model.Autor+"','"+model.Actores+"','"+model.Año+"','"+model.Sipnosis+"')";
                if (cn.Execute(sql, model) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Update(PeliculasModel model)
        {
            using (var cn = Conexion.Conectar())
            {
                string sql = "UPDATE peliculas SET nombre ='" + model.Nombre + "' , autor ='" + model.Autor + "', actores ='" + model.Actores + "', año ='" + model.Año + "', sipnosis = '" + model.Sipnosis + "' WHERE id = '"+model.Id+"'";
                if (cn.Execute(sql, model) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            using (var cn = Conexion.Conectar())
            {
                string sql = "DELETE FROM peliculas WHERE id = '"+id+"'";
                if (cn.Execute(sql) > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}