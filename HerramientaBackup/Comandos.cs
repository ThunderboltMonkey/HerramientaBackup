using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HerramientaBackup
{
    class Comandos
    {

        // RESPALDAR //
        public void rutas_de_respaldo(TextBox ruta)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre del respaldo: ", "G U A R D A R");
            if (folder.ShowDialog() == DialogResult.OK)
            {
                ruta.Text = folder.SelectedPath + "\\" + nombre + ".sql";
            }

        }

        public void Respaldar_Base_De_Datos(TextBox textBox)
        {
            string basededatos = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el nombre de la base de datos:", "R E S P A L D O");

            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                proc.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 8.0\bin");
                proc.StandardInput.Flush();
                proc.StandardInput.WriteLine(@"mysqldump -hlocalhost -P3306 -uroot -pNelly9831 --opt --routines --add-drop-database --databases "+ basededatos +">" + textBox.Text);
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                MessageBox.Show("Respaldo hecho de manera correcta.", "A V I S O", MessageBoxButtons.OK);
            } catch
            {
                MessageBox.Show("No se pudo realizar el respaldo, hubo un error","E R R O R",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Respaldar_Todas_Bases_De_Datos(TextBox textBox)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                proc.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 8.0\bin");
                proc.StandardInput.Flush();
                proc.StandardInput.WriteLine(@"mysqldump -hlocalhost -P3306 -uroot -pNelly9831 --opt --routines --add-drop-database --all-databases>" + textBox.Text);
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                MessageBox.Show("Respaldo hecho de manera correcta.", "A V I S O", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("No se pudo realizar el respaldo, hubo un error", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Respaldar_Tabla(TextBox textBox)
        {
            string basededatos = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el nombre de la base de datos:", "R E S P A L D O");
            string tabla = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el nombre de la tabla:", "R E S P A L D O");

            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                proc.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 8.0\bin");
                proc.StandardInput.Flush();
                proc.StandardInput.WriteLine(@"mysqldump -hlocalhost -P3306 -uroot -pNelly9831 --opt --routines --add-drop-database " + basededatos + " " + tabla + ">" + textBox.Text);
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                MessageBox.Show("Respaldo hecho de manera correcta.", "A V I S O", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("No se pudo realizar el respaldo, hubo un error", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Respaldar_Varias_Tablas(TextBox textBox)
        {
            string basededatos = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el nombre de la base de datos:", "R E S P A L D O");
            string tablas = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el nombre de la tablas separadas por un espacio:\nEjemplo:Tabla1 Tabla2 Tabla3... Tabla#", "R E S P A L D O");

            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                proc.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 8.0\bin");
                proc.StandardInput.Flush();
                proc.StandardInput.WriteLine(@"mysqldump -hlocalhost -P3306 -uroot -pNelly9831 --opt --routines --add-drop-database " + basededatos + " " + tablas + ">" + textBox.Text);
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                MessageBox.Show("Respaldo hecho de manera correcta.", "A V I S O", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("No se pudo realizar el respaldo, hubo un error", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // RESTAURAR //
        public void ruta_de_restauracion(TextBox ruta)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                ruta.Text = abrir.FileName;
            }
        }

        public void Restaurar_Base_De_Datos(TextBox textBox)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                proc.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 8.0\bin");
                proc.StandardInput.Flush();
                proc.StandardInput.WriteLine(@"mysql -u root -pNelly9831 -e " + "\"source " + textBox.Text + "\"");
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                MessageBox.Show("Se ha restaurado de manera correcta.", "A V I S O", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la restauración, hubo un error", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Restaurar_Todas_Las_Bases_De_Datos(TextBox textBox)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                proc.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 8.0\bin");
                proc.StandardInput.Flush();
                proc.StandardInput.WriteLine(@"mysql -u root -pNelly9831 -e " + "\"source " + textBox.Text + "\"");
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                MessageBox.Show("Se ha restaurado de manera correcta.", "A V I S O", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la restauración, hubo un error", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Restaurar_Todas_Las_Tablas(TextBox textBox)
        {
            MessageBox.Show("Es necesario que exista la base de datos", "A V I S O", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            string basededatos = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el nombre de la base de datos:", "R E S P A L D O");

            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                proc.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 8.0\bin");
                proc.StandardInput.Flush();
                proc.StandardInput.WriteLine(@"mysql -u root -pNelly9831 " +  basededatos + " < " + textBox.Text + " -f");
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                MessageBox.Show("Se ha restaurado de manera correcta.", "A V I S O", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la restauración, hubo un error", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Restaurar_Tabla(TextBox textBox)
        {
            MessageBox.Show("Es necesario que exista la base de datos", "A V I S O", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            string basededatos = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el nombre de la base de datos:", "R E S P A L D O");

            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                proc.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 8.0\bin");
                proc.StandardInput.Flush();
                proc.StandardInput.WriteLine(@"mysql -u root -pNelly9831 " + basededatos + " < " + textBox.Text + " -f");
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                MessageBox.Show("Se ha restaurado de manera correcta.", "A V I S O", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la restauración, hubo un error", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}