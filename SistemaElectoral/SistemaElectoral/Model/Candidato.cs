using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Candidato {
        private int id;
        private String nombre;
        

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        
    }
}