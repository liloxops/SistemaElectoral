using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Genero {
        private int id;
        private String descripcion;

        public int Id {
            get { return Id; }
            set { Id = value; }
        }
        public string Descripcion {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
    }
}