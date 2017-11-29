using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaElectoral.Model;
namespace SistemaElectoral.Controller
{
    /// <summary>
    /// Descripción breve de votacionHandler
    /// </summary>
    public class votacionHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            String voto = context.Request.Params["voto"];
            String StrComuna = context.Request.Params["comuna"];


            Data d = new Data();

            Votacion vo = new Votacion();
            context.Response.Write(StrComuna);
            if (voto != null && StrComuna != null)
            {
                int idComuna = int.Parse(StrComuna);
                vo.Fk_candidato = int.Parse(voto);
                vo.Fk_comuna = idComuna;
                d.countVotos();
                d.votar(vo);

                context.Response.Redirect("../View/Default.aspx");
            }
            else
            {

                context.Response.Redirect("/votarHandler.ashx");
            }
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}