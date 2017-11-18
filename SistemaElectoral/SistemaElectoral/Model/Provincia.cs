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
            get { return Id; }
            set { Id = value; }
        }
        public string Nombre {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int Fk_region {
            get { return Fk_region; }
            set { Fk_region = value; }
        }
    }
}