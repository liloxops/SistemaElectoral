using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Partido {
        private int id;
        private String descripcion;
        private int fk_sector;

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Descripcion {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        public int Fk_sector {
            get { return this.fk_sector; }
            set { this.fk_sector = value; }
        }
    }
}