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
            get { return Id; }
            set { Id = value; }
        }
        public string Descripcion {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public int Fk_sector {
            get { return Fk_sector; }
            set { Fk_sector = value; }
        }
    }
}