using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Perfil {
        private int id;
        private String nombre;

        public int Id {
            get { return Id; }
            set { Id = value; }
        }
        public string Nombre {
            get { return Nombre; }
            set { Nombre = value; }
        }
    }
}