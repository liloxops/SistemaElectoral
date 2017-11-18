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
            get { return Id; }
            set { Id = value; }
        }
        public bool VotoBlanco {
            get { return VotoBlanco; }
            set { VotoBlanco = value; }
        }
        public bool VotoNulo {
            get { return VotoNulo; }
            set { VotoNulo = value; }
        }
        public bool VotoCandidato {
            get { return VotoCandidato; }
            set { VotoCandidato = value; }
        }
        public int Fk_candidato {
            get { return Fk_candidato; }
            set { Fk_candidato = value; }
        }
        public int Fk_persona {
            get { return Fk_persona; }
            set { Fk_persona = value; }
        }
    }
}