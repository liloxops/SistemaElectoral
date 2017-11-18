using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Persona {
        private int id;
        private String rut;
        private String nombre;
        private int edad;
        private int fk_genero;
        private int fk_comuna;

        public int Id {
            get { return Id; }
            set { Id = value; }
        }
        public string Rut {
            get { return Rut; }
            set { Rut = value; }
        }
        public string Nombre {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int Edad {
            get { return Edad; }
            set { Edad = value; }
        }
        public int Fk_genero {
            get { return Fk_genero; }
            set { Fk_genero = value; }
        }
        public int Fk_comuna {
            get { return Fk_comuna; }
            set { Fk_comuna = value; }
        }
    }
}