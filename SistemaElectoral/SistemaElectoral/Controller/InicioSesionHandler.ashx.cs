using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaElectoral.Model;
using System.Web.SessionState;

namespace SistemaElectoral.Controller
{
    /// <summary>
    /// Descripción breve de InicioSesionHandler
    /// </summary>
    public class InicioSesionHandler : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            Data d = new Data();

            String nombre, pass;

            nombre = context.Request.Params["txt_Nom"];
            pass = context.Request.Params["txt_Pass"];

            Usuario u = d.usuarioIngreso(nombre,pass);

            if (u == null)
            {
                context.Response.Redirect("../View/Error.aspx");
                context.Session["error"] = "Usuario Incorrecto";
            }
            else {
                context.Session["usuario"] = u;
                context.Response.Redirect("../View/Default.aspx");
                
                
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}