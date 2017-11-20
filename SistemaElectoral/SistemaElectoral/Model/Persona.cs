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
            get { return this.id; }
            set { this.id = value; }
        }
        public string Rut {
            get { return this.rut; }
            set { this.rut = value; }
        }
        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Edad {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public int Fk_genero {
            get { return this.fk_genero; }
            set { this.fk_genero = value; }
        }
        public int Fk_comuna {
            get { return this.fk_comuna; }
            set { this.fk_comuna = value; }
        }
    }
}