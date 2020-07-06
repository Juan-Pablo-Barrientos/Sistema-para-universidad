using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios FormUsuarios = new Usuarios();
            FormUsuarios.ShowDialog();
        }

        private void tsbMaterias_Click(object sender, EventArgs e)
        {
            Materias FormMaterias = new Materias();
            FormMaterias.ShowDialog();
        }
    }
}
