using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Candidato {
        private int id;
        private String nombre;
        private int fk_partida;

        public int Id {
            get { return id; }
            set { id = value; }
        }
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Fk_partida {
            get { return Fk_partida; }
            set { Fk_partida = value; }
        }
    }
}