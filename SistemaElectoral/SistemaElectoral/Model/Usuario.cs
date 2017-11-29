using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Usuario {
        private int id;
        private String nombre;
        private String pass;

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Pass {
            get { return this.pass; }
            set { this.pass = value; }
        }
    }
}