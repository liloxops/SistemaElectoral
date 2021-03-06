﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Data
    {
        private Conexion con;
        private String query;

        public Data()
        {
            con = new Conexion("eleciones2018");
        }

        public void votar(Votacion v)
        {

            query = "insert into votacion values('" + v.Fk_candidato + "','" + v.Fk_comuna + "');";

            con.Ejecutar(query);

        }
        public int countVotos()
        {
            Votacion v = new Votacion();
            int votos = 0;

            query = "select count(fk_Candidato) from votacion where fk_Candidato ='" + v.Fk_candidato + "'";

            con.Ejecutar(query);

            while (con.rs.Read())
            {
                votos = con.rs.GetInt32(0);
            }
            con.Cerrar();

            return votos;

        }
        public List<Comuna> getListaComuna(String id)
        {
            List<Comuna> lis = new List<Comuna>();
            query = "select * from comuna where fk_Provincia = " + id;
            con.Ejecutar(query);
            Comuna p;
            while (con.rs.Read())
            {
                p = new Comuna();

                p.Id = con.rs.GetInt32(0);
                p.Nombre = con.rs.GetString(1);
                p.Fk_provincia = con.rs.GetInt32(2);

                lis.Add(p);
            }

            con.Cerrar();
            return lis;
        }



        public List<Candidato> getListaCandidatos()
        {
            List<Candidato> listaCandi = new List<Candidato>();
            query = "select * from candidato";

            con.Ejecutar(query);
            Candidato c;
            while (con.rs.Read())
            {
                c = new Candidato();

                c.Id = con.rs.GetInt32(0);
                c.Nombre = con.rs.GetString(1);

                listaCandi.Add(c);
            }
            con.Cerrar();
            return listaCandi;
        }

        public String getComuna(string a)
        {
            a = "algo";
            return a;
        }
        public List<Provincia> getListaProvincia()
        {
            List<Provincia> lis = new List<Provincia>();
            query = "SELECT * FROM provincia";

            con.Ejecutar(query);
            Provincia p;
            while (con.rs.Read())
            {
                p = new Provincia();

                p.Id = con.rs.GetInt32(0);
                p.Nombre = con.rs.GetString(1);
                p.Fk_region = con.rs.GetInt32(2);

                lis.Add(p);
            }

            con.Cerrar();
            return lis;
        }

        
        public Usuario usuarioIngreso(String nombre, String pass)
        {
            query = "select * from usuario where nombre = '"+nombre+"' and pass = '"+pass+"'";

            con.Ejecutar(query);

            Usuario u = null;

            if (con.rs.Read()) {
                u = new Usuario();

                u.Id = con.rs.GetInt32(0);
                u.Nombre = con.rs.GetString(1);
                u.Pass = con.rs.GetString(2);
            }
            con.Cerrar();
            return u;
        }

    }
}