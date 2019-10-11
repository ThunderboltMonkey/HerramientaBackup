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
    public partial class FormaRestaura : Form
    {
        Comandos cmd = new Comandos();

        public FormaRestaura()
        {
            InitializeComponent();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            cmd.Restaurar_Base_De_Datos(txtRuta);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            cmd.ruta_de_restauracion(txtRuta);
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            cmd.Restaurar_Todas_Las_Bases_De_Datos(txtRuta);
        }

        private void btnRestTablas_Click(object sender, EventArgs e)
        {
            cmd.Restaurar_Todas_Las_Tablas(txtRuta);
        }

        private void btnRestTabla_Click(object sender, EventArgs e)
        {
            cmd.Restaurar_Tabla(txtRuta);
        }

    }
}
