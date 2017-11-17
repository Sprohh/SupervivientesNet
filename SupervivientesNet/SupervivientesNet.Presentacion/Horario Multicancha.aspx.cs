using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SupervivientesNet.Negocios;
namespace SupervivientesNet.Presentacion
{
    public partial class Horario_Multicancha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Coleccion col = new Coleccion();
            string[,] sche = col.getHorario(3);
            //Lunes
            if (sche[0, 0] != null)
            {
                Lbl00.Text = sche[0, 0];
            }
            if (sche[1, 0] != null)
            {
                Lbl10.Text = sche[1, 0];
            }
            if (sche[2, 0] != null)
            {
                Lbl20.Text = sche[2, 0];
            }
            if (sche[3, 0] != null)
            {
                Lbl30.Text = sche[3, 0];
            }
            if (sche[4, 0] != null)
            {
                Lbl40.Text = sche[4, 0];
            }

            if (sche[5, 0] != null)
            {
                Lbl50.Text = sche[5, 0];
            }

            if (sche[6, 0] != null)
            {
                Lbl60.Text = sche[6, 0];
            }

            if (sche[7, 0] != null)
            {
                Lbl70.Text = sche[7, 0];
            }

            if (sche[8, 0] != null)
            {
                Lbl80.Text = sche[8, 0];
            }

            if (sche[9, 0] != null)
            {
                Lbl90.Text = sche[9, 0];
            }

            if (sche[10, 0] != null)
            {
                Lbl100.Text = sche[10, 0];
            }

            if (sche[11, 0] != null)
            {
                Lbl110.Text = sche[11, 0];
            }

            if (sche[12, 0] != null)
            {
                Lbl120.Text = sche[12, 0];
            }

            if (sche[13, 0] != null)
            {
                Lbl130.Text = sche[13, 0];
            }

            if (sche[14, 0] != null)
            {
                Lbl140.Text = sche[14, 0];
            }

            //Martes
            if (sche[0, 1] != null)
            {
                Lbl01.Text = sche[0, 1];
            }
            if (sche[1, 1] != null)
            {
                Lbl11.Text = sche[1, 1];
            }
            if (sche[2, 1] != null)
            {
                Lbl21.Text = sche[2, 1];
            }
            if (sche[3, 1] != null)
            {
                Lbl31.Text = sche[3, 1];
            }
            if (sche[4, 1] != null)
            {
                Lbl41.Text = sche[4, 1];
            }

            if (sche[5, 1] != null)
            {
                Lbl51.Text = sche[5, 1];
            }

            if (sche[6, 1] != null)
            {
                Lbl61.Text = sche[6, 1];
            }

            if (sche[7, 1] != null)
            {
                Lbl71.Text = sche[7, 1];
            }

            if (sche[8, 1] != null)
            {
                Lbl81.Text = sche[8, 1];
            }

            if (sche[9, 1] != null)
            {
                Lbl91.Text = sche[9, 1];
            }

            if (sche[10, 1] != null)
            {
                Lbl101.Text = sche[10, 1];
            }

            if (sche[11, 1] != null)
            {
                Lbl111.Text = sche[11, 1];
            }

            if (sche[12, 1] != null)
            {
                Lbl121.Text = sche[12, 1];
            }

            if (sche[13, 1] != null)
            {
                Lbl131.Text = sche[13, 1];
            }

            if (sche[14, 1] != null)
            {
                Lbl141.Text = sche[14, 1];
            }
            //Miercoles
            if (sche[0, 2] != null)
            {
                Lbl02.Text = sche[0, 2];
            }
            if (sche[1, 2] != null)
            {
                Lbl12.Text = sche[1, 2];
            }
            if (sche[2, 2] != null)
            {
                Lbl22.Text = sche[2, 2];
            }
            if (sche[3, 2] != null)
            {
                Lbl32.Text = sche[3, 2];
            }
            if (sche[4, 2] != null)
            {
                Lbl42.Text = sche[4, 2];
            }

            if (sche[5, 2] != null)
            {
                Lbl52.Text = sche[5, 2];
            }

            if (sche[6, 2] != null)
            {
                Lbl62.Text = sche[6, 2];
            }

            if (sche[7, 2] != null)
            {
                Lbl72.Text = sche[7, 2];
            }

            if (sche[8, 2] != null)
            {
                Lbl82.Text = sche[8, 2];
            }

            if (sche[9, 2] != null)
            {
                Lbl92.Text = sche[9, 2];
            }

            if (sche[10, 2] != null)
            {
                Lbl102.Text = sche[10, 2];
            }

            if (sche[11, 2] != null)
            {
                Lbl112.Text = sche[11, 2];
            }

            if (sche[12, 2] != null)
            {
                Lbl122.Text = sche[12, 2];
            }

            if (sche[13, 2] != null)
            {
                Lbl132.Text = sche[13, 2];
            }

            if (sche[14, 2] != null)
            {
                Lbl142.Text = sche[14, 2];
            }
            //Jueves
            if (sche[0, 3] != null)
            {
                Lbl03.Text = sche[0, 3];
            }
            if (sche[1, 3] != null)
            {
                Lbl13.Text = sche[1, 3];
            }
            if (sche[2, 3] != null)
            {
                Lbl23.Text = sche[2, 3];
            }
            if (sche[3, 3] != null)
            {
                Lbl33.Text = sche[3, 3];
            }
            if (sche[4, 3] != null)
            {
                Lbl43.Text = sche[4, 3];
            }

            if (sche[5, 3] != null)
            {
                Lbl53.Text = sche[5, 3];
            }

            if (sche[6, 3] != null)
            {
                Lbl63.Text = sche[6, 3];
            }

            if (sche[7, 3] != null)
            {
                Lbl73.Text = sche[7, 3];
            }

            if (sche[8, 3] != null)
            {
                Lbl83.Text = sche[8, 3];
            }

            if (sche[9, 3] != null)
            {
                Lbl93.Text = sche[9, 3];
            }

            if (sche[10, 3] != null)
            {
                Lbl103.Text = sche[10, 3];
            }

            if (sche[11, 3] != null)
            {
                Lbl113.Text = sche[11, 3];
            }

            if (sche[12, 3] != null)
            {
                Lbl123.Text = sche[12, 3];
            }

            if (sche[13, 3] != null)
            {
                Lbl133.Text = sche[13, 3];
            }

            if (sche[14, 3] != null)
            {
                Lbl143.Text = sche[14, 3];
            }
            //Viernes
            if (sche[0, 4] != null)
            {
                Lbl04.Text = sche[0, 4];
            }
            if (sche[1, 4] != null)
            {
                Lbl14.Text = sche[1, 4];
            }
            if (sche[2, 4] != null)
            {
                Lbl24.Text = sche[2, 4];
            }
            if (sche[3, 4] != null)
            {
                Lbl34.Text = sche[3, 4];
            }
            if (sche[4, 4] != null)
            {
                Lbl44.Text = sche[4, 4];
            }

            if (sche[5, 4] != null)
            {
                Lbl54.Text = sche[5, 4];
            }

            if (sche[6, 4] != null)
            {
                Lbl64.Text = sche[6, 4];
            }

            if (sche[7, 4] != null)
            {
                Lbl74.Text = sche[7, 4];
            }

            if (sche[8, 4] != null)
            {
                Lbl84.Text = sche[8, 4];
            }

            if (sche[9, 4] != null)
            {
                Lbl94.Text = sche[9, 4];
            }

            if (sche[10, 4] != null)
            {
                Lbl104.Text = sche[10, 4];
            }

            if (sche[11, 4] != null)
            {
                Lbl114.Text = sche[11, 4];
            }

            if (sche[12, 4] != null)
            {
                Lbl124.Text = sche[12, 4];
            }

            if (sche[13, 4] != null)
            {
                Lbl134.Text = sche[13, 4];
            }

            if (sche[14, 4] != null)
            {
                Lbl144.Text = sche[14, 4];
            }
            //Sabado
            if (sche[0, 5] != null)
            {
                Lbl05.Text = sche[0, 5];
            }
            if (sche[1, 5] != null)
            {
                Lbl15.Text = sche[1, 5];
            }
            if (sche[2, 5] != null)
            {
                Lbl25.Text = sche[2, 5];
            }
            if (sche[3, 5] != null)
            {
                Lbl35.Text = sche[3, 5];
            }
            if (sche[4, 5] != null)
            {
                Lbl45.Text = sche[4, 5];
            }

            if (sche[5, 5] != null)
            {
                Lbl55.Text = sche[5, 5];
            }

            if (sche[6, 5] != null)
            {
                Lbl65.Text = sche[6, 5];
            }

            if (sche[7, 5] != null)
            {
                Lbl75.Text = sche[7, 5];
            }

            if (sche[8, 5] != null)
            {
                Lbl85.Text = sche[8, 5];
            }

            if (sche[9, 5] != null)
            {
                Lbl95.Text = sche[9, 5];
            }

            if (sche[10, 5] != null)
            {
                Lbl105.Text = sche[10, 5];
            }

            if (sche[11, 5] != null)
            {
                Lbl115.Text = sche[11, 5];
            }

            if (sche[12, 5] != null)
            {
                Lbl125.Text = sche[12, 5];
            }

            if (sche[13, 5] != null)
            {
                Lbl135.Text = sche[13, 5];
            }

            if (sche[14, 5] != null)
            {
                Lbl145.Text = sche[14, 5];
            }
        }
    }
}