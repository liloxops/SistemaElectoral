using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Provincia {
        private int id;
        private String nombre;
        private int fk_region;

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Fk_region {
            get { return this.fk_region; }
            set { this.fk_region = value; }
        }
    }
}