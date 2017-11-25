using System;
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
                c.Fk_partida = con.rs.GetInt32(2);

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

    }
}