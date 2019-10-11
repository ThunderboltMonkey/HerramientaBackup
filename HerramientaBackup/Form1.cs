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
    public partial class Form1 : Form
    {
        Pen pluma = new Pen(Color.FromArgb(244, 176, 66),5f);

        SolidBrush brocha = new SolidBrush(Color.FromArgb(244, 176, 66));

        public Form1()
        {
            InitializeComponent();
        }

        public void FormRespaldo()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormaRespaldo")
                {
                    f.Activate();
                    return;
                }
            }
            FormaRespaldo FR = new FormaRespaldo();
            FR.Show();
        }

        public void FormRestaura()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormaRestaura")
                {
                    f.Activate();
                    return;
                }
            }
            FormaRestaura FR = new FormaRestaura();
            FR.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void respaldarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pluma, 18, 87, 758, 87);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRespaldo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRestaura();
        }
    }
}
