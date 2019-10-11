using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HerramientaBackup
{
    public partial class FormaRespaldo : Form
    {
        Comandos cmd = new Comandos();

        public FormaRespaldo()
        {
            InitializeComponent();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            cmd.Respaldar_Base_De_Datos(txtRuta);
        }

        private void btnRespTablas_Click(object sender, EventArgs e)
        {
            cmd.Respaldar_Varias_Tablas(txtRuta);
        }

        private void btnRespTabla_Click(object sender, EventArgs e)
        {
            cmd.Respaldar_Tabla(txtRuta);
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            cmd.Respaldar_Todas_Bases_De_Datos(txtRuta);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            cmd.rutas_de_respaldo(txtRuta);
        }
    }
}
