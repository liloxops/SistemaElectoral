using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Data {
        private Conexion con;
        private String query;

        public Data() {
            con = new Conexion("eleciones2018");
        }

        
        public List<Comuna> getListaComuna(String id) {
            List<Comuna> lis = new List<Comuna>();
            query = "SELECT * FROM comuna WHERE fk_Provincia =" + id;
            con.Ejecutar(query);
            Comuna p;
            while (con.rs.Read()) {
                p = new Comuna();

                p.Id = con.rs.GetInt32(0);
                p.Nombre = con.rs.GetString(1);
                p.Fk_provincia = con.rs.GetInt32(2);

                lis.Add(p);
            }

            con.Cerrar();
            return lis;
        }

        public String getComuna(string a) {
            a = "algo";
            return a;
        }
        public List<Provincia> getListaProvincia() {
            List<Provincia> lis = new List<Provincia>();
            query = "SELECT * FROM provincia";

            con.Ejecutar(query);
            Provincia p;
            while (con.rs.Read()) {
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