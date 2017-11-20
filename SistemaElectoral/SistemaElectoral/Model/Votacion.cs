using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaElectoral.Model {
    public class Votacion {
        private int id;
        private Boolean votoBlanco;
        private Boolean votoNulo;
        private Boolean votoCandidato;
        private int fk_candidato;
        private int fk_persona;

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public bool VotoBlanco {
            get { return this.votoBlanco; }
            set { this.votoBlanco = value; }
        }
        public bool VotoNulo {
            get { return this.votoNulo; }
            set { this.votoNulo = value; }
        }
        public bool VotoCandidato {
            get { return this.votoCandidato; }
            set { this.votoCandidato = value; }
        }
        public int Fk_candidato {
            get { return this.fk_candidato; }
            set { this.fk_candidato = value; }
        }
        public int Fk_persona {
            get { return this.fk_persona; }
            set { this.fk_persona = value; }
        }
    }
}