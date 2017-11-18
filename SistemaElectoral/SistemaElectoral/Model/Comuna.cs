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
            get { return Id; }
            set { Id = value; }
        }
        public string Nombre {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int Fk_provincia {
            get { return Fk_provincia; }
            set { Fk_provincia = value; }
        }
    }
}