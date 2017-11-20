using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Sector {
        private int id;
        private String descripcion;

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Descripcion {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
    }
}