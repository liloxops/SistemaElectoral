using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SistemaElectoral.Controller
{
    /// <summary>
    /// Descripción breve de cerrarSesionHandler
    /// </summary>
    public class cerrarSesionHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["usuario"]!= null) {
                context.Session.RemoveAll();
                context.Response.Redirect("../View/InicioSesion.aspx");
            }
            

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}