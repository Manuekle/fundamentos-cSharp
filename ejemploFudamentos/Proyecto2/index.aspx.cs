using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) => MostarMensaje();
        public void MostarMensaje()
        {
            Car car = new Car();
            string msj = car.stop();
            LblMensaje.Text = msj;
        }
    }
}
