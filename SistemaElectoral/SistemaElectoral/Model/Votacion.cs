using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Votacion {
        private int id;
        private int fk_candidato;
        private int fk_comuna;

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        
        public int Fk_candidato {
            get { return this.fk_candidato; }
            set { this.fk_candidato = value; }
        }
        public int Fk_comuna {
            get { return this.fk_comuna; }
            set { this.fk_comuna = value; }
        }
    }
}