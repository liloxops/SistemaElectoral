using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Comuna {
        private int id;
        private String nombre;
        private int fk_provincia;

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Fk_provincia {
            get { return this.fk_provincia; }
            set { this.fk_provincia = value; }
        }
    }
}