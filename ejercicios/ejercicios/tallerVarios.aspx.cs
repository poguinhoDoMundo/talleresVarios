using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicios
{
    public partial class tallerVarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sumaPares.InnerHtml = Convert.ToString(  getSumPares());
        }

        private int getSumPares()
        {

            int sumaPares = 0;
            
            for ( int i = 0; i<=50;i++  )
            {
                if ((i % 2) == 0)
                    sumaPares++;
            }

            return sumaPares;
        }

    }
}