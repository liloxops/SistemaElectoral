using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SistemaElectoral.Model;

namespace SistemaElectoral.Controller {
    /// <summary>
    /// Descripción breve de CargarComboComuna
    /// </summary>
    public class CargarComboComuna : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            String filtro = context.Request.Params["id"];

            Data d = new Data();

            foreach (Comuna c in d.getListaComuna(filtro))
            {
                context.Response.Write("<otion>-- Seleccionar --</option>");
                context.Response.Write("<option value='" + c.Id + "'>" + c.Nombre + " </option>"); ;
            }
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}