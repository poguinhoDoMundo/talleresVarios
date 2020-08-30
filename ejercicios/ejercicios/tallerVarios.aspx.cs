using System;
using System.Collections.Generic;
using System.Configuration;
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
            
            //me voy desde 0 hasta 50 
            for ( int i = 0; i<=50;i++  )
            {
                //si la division entre 2 nos da de residuo 0 es x q es par 
                if ((i % 2) == 0)
                    sumaPares = sumaPares + i;
            }

            return sumaPares;
        }


        private int sumaMultiplo5()
        {
            int sumaMultiplos = 0;

            //me voy desde 0 hasta 100
            for ( int i= 1; i<=100;i++  )
            {
                //si el residuo de la division entre 5 da 0 es x q es multiplo de 5
                if ((i % 5) == 0)
                    sumaMultiplos = sumaMultiplos + i;
            }

            return sumaMultiplos;
        }


        private int getSumImpares()
        {

            int sumaImpares = 0;

            //me voy desde 0 hasta 300
            for (int i = 0; i <= 300; i++)
            {
                //si la division entre 2 nos da de residuo 0 es x q es par, entonces los q sean diferentes son impares 
                if ((i % 2) != 0)
                    sumaImpares= sumaImpares + 1;
            }

            return sumaImpares;
        }


        private void getIfs()
        {

            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;

            //me voy desde 0 hasta 100
            for (int i = 0; i <= 100; i++)
            {
                //si esta entre mas de 50 y menos de 36 al contador le sumo de ano
                if ( ( i>=50 && i<=66 ) )
                    cont1=cont1+1;

                //los numeros q son mayores a 79
                if (i >= 79)
                    cont2=cont2+1;

                //si son menores de 18
                if (i <= 18)
                    cont3=cont3+1;

            }

            Console.WriteLine("numeros entre 50 y 66 " +  cont1 );
            Console.WriteLine("numeros mayores a 79 " + cont2);
            Console.WriteLine("numeros menores a 18 " + cont3);


        }

    }
}