using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        //NOTIFICACION TIENE Q SER UN METODO BUSINESS LOGIC,LOGIN APENAS INICIA.
        //Materias se modifico para que ID PLAN sea NULL, MateriaAdapter con lineas ID PLAN comentadas.
    }
}
