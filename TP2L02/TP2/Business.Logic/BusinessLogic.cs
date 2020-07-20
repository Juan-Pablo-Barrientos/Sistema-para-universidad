using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Logic
{
    public class BusinessLogic
    {
        static public void  Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)      
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

    }

}
